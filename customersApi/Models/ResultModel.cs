using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Models
{
    public class ResultModel
    {
        public bool HasError { get; set; }
        public string httpstatus { get; set; }
        public string Messages { get; set; }

        public object Data { get; set; }


        public static ResultModel Error(string error,string httpstatus)
        {
            return new ResultModel
            {
                httpstatus= httpstatus,
                HasError = true,
                Messages = error,
                Data = null
            };
        }


        public static ResultModel Ok( string httpstatus,object data = null, string message = "", object headers = null)
        {
            return new ResultModel
            {
                httpstatus = httpstatus,
                HasError = false,
                Messages = message,
                Data = data
               
            };
        }
    }
}
