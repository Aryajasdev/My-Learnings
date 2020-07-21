using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace myfirstLambda
{
    public class Student
    {
        public int Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() {
            return "I am: " + FirstName + " " + LastName;
        }
    }

    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string FunctionHandler(Student student, ILambdaContext context)
        {
            return student.ToString();
        }
    }
}
