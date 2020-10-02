using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [Discriminator(nameof(Code))]
    public abstract partial class ErrorObject 
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
    }
}
