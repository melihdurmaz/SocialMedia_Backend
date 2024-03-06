using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Concrete
{
    public class ErrorSuccesDataResult
    {
        public ErrorSuccesDataResult(T data, string message) : base(data, false, message)
        {

        }
        public ErrorSuccesDataResult(T data) : base(data, false)
        {

        }
        public ErrorSuccesDataResult(string message) : base(default, false, message)
        {

        }
        public ErrorSuccesDataResult() : base(default, false)
        {

        }
    }
}
