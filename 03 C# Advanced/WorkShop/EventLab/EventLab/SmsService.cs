using System;

namespace EventLab
{
    public class SmsService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"{args.Video.Title }: Sms was sended");
        }
    }


}
