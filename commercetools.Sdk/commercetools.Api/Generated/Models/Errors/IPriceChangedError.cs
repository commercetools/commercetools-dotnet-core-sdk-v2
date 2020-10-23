using commercetools.Api.Generated.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Errors
{
    public interface IPriceChangedError : IErrorObject
    {
        List<string> LineItems { get; set;}
        
        bool Shipping { get; set;}
    }
}
