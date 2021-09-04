using Microsoft.Extensions.Configuration;
using SmsIrRestful;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Framework.Application.Sms
{
    public class SmsService : ISmsService
    {
        private readonly IConfiguration _configuration;

        public SmsService(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public void Send(string number, string message)
        {
            var token = GetToken();
            var lines = new SmsLine().GetSmsLines(token);
            if (lines == null) return;

            var line = lines.SMSLines.Last().LineNumber.ToString();
            var data = new MessageSendObject
            {
                Messages = new List<string>
                    {message}.ToArray(),
                MobileNumbers = new List<string> { number }.ToArray(),
                LineNumber = number,
                SendDateTime = DateTime.Now,
                CanContinueInCaseOfError = true
            };
            var messageSendResponseObject = new MessageSend().Send(token, data);
            if (messageSendResponseObject.IsSuccessful) return;

            line = lines.SMSLines.First().LineNumber.ToString();
            data.LineNumber = line;
            new MessageSend().Send(token, data);
        }

        private string GetToken()
        {
            //var smsSecrets = _configuration.GetSection("SmsSecrets");
            //var tokenService = new Token();
            //return tokenService.GetToken(smsSecrets["ApiKey"], smsSecrets["SecretKey"]);

            var tokenService = new Token();
            var apiKey = _configuration["SmsSecrets:ApiKey"];
            var secretKey = _configuration["SmsSecrets:SecretKey"];

            return tokenService.GetToken(apiKey, secretKey);
        }
    }
}
