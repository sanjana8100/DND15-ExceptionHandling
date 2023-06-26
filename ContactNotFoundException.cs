using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND15_ExceptionHandling
{
    internal class ContactNotFoundException : Exception
    {
        public ContactNotFoundException() { }

        public ContactNotFoundException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
