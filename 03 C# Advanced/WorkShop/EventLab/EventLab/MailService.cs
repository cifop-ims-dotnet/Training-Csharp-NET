﻿using System;

namespace EventLab
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"{args.Video.Title }: Mail was sended");
        }
    }
}
