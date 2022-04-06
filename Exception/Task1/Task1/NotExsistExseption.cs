using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class NotExsistExseption : Exception
    {
        public NotExsistExseption(string message) : base(message)
        {

        }

    }
}
