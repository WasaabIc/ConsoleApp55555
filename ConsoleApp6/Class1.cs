using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatar
{
    public class WordDetectedException : Exception
    {
        public WordDetectedException(string message) : base(message)
        {

        }
    }
}
