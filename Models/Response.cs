using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace luuga1998.Models
{
    public class Response<T>
    {
        public int error;
        public string message;
        public T data;
        public Response(int error,string message,T data )
        {
            this.error = error;
            this.message = message;
            this.data = data;
        }
    }
}