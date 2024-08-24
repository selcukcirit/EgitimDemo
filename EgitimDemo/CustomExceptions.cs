using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimDemo
{
    public static class CustomExceptions
    {

        public class IndexSifirdanKucukException : Exception
        {
            public IndexSifirdanKucukException()
            {                
            }

            public IndexSifirdanKucukException(string message, Exception innerException): base(message, innerException)
            {                 
            }
        }

        public class IndexDizininBoyutundanBuyukException : Exception
        {
            public IndexDizininBoyutundanBuyukException()
            {
            }

            public IndexDizininBoyutundanBuyukException(string message, Exception innerException) : base(message, innerException)
            {
            }
        }
    }
}
