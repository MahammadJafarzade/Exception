using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class EmailSender:MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("Email sended");
        }
    }
}
