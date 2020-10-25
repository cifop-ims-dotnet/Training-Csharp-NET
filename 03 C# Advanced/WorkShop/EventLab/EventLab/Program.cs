namespace EventLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "Matrix" };
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            var smsService = new SmsService();

            // subcription
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += smsService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
