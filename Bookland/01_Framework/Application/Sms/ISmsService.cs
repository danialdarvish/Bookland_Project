namespace _01_Framework.Application.Sms
{
    public interface ISmsService
    {
        void Send(string number, string message);
    }
}
