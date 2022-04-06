using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class SmsSender:MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("sms sended");
        }
    }
}
