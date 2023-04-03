using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplication.Wrapper
{
    public class Response<T>
    {

        public bool Succeded { get; set; }
        public string Message { get; set; }   
        public List<string> Errors { get; set; }
        public T Data { get; set; }
        public Response() 
        { 
           
        }
        public Response(T Data, string messager = null)
        {
            Succeded = true;
            Message = messager;
            Data = Data;
       

        }
        public Response(string mensajes)
        {
            Succeded = true;
            Message = mensajes;
        }
    }
}
