using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public abstract class MessageSender
    {
        public virtual void SendMessage()
        {
            Console.WriteLine("Message sended");
        }
    }
}
