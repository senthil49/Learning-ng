using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace To_Do.Model
{
    public class Response<T>
    {
        public bool ResponseFlag { get; set; }
        public T Data { get; set; }
    }
}