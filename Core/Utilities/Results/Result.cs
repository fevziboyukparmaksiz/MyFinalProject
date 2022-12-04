using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message) :this(success)
        {
            // :this(succes) aşağıdak, ctoru da kapsıyor. yani istersek sadece success ya da hem succes hem message
            Message= message;
        }
        public Result(bool success)
        {
            Success= success;
        }
        // getler readonlydir sadece ctor da set edilebilir!!!
        public bool Success { get; }

        public string Message { get; }
    }
}
