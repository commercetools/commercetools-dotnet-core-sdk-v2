using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class InvalidCurrentPasswordError : IInvalidCurrentPasswordError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        public InvalidCurrentPasswordError()
        { 
           this.Code = "InvalidCurrentPassword";
        }
    }
}
