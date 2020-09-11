using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Errors
{
    public class ErrorResponse 
    {
        public int StatusCode { get; set;}
        
        public string Message { get; set;}
        
        public string Error { get; set;}
        
        public string Error_description { get; set;}
        
        public List<ErrorObject> Errors { get; set;}
    }
}
