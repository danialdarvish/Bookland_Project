namespace _01_Framework.Application
{
    public class SmsMessages
    {
        public static string PaymentSucceeded(string name, string issueTrackingNo)
        {
            return $"{name} عزیز، سفارش شما با کد پیگیری {issueTrackingNo} موفقیت ثبت و پرداخت شد. \n" +
                   $"با سپاس، بوک لند";
        }
    }
}
