using System;
using System.Collections.Generic;
using System.Text;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1:Send message by email");
            Console.WriteLine("2:Send message by sms");
            Console.WriteLine("0:Quit");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                EmailSender();
            }
            else if (number == 2)
            {
                SmsSender();
            }
            else if (number == 0)
            {
                Console.WriteLine("Quit");
            }
                
        }

        private static void SmsSender()
        {
            throw new NotImplementedException();
        }

        private static void EmailSender()
        {
            throw new NotImplementedException();
        }
    }
}
