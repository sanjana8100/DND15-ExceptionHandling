using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND15_ExceptionHandling
{
    internal class DuplicateContactException : Exception
    {
        public DuplicateContactException() {}

        public DuplicateContactException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
