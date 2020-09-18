using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [Discriminator(nameof(Code))]
    public abstract class ErrorObject 
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
    }
}
