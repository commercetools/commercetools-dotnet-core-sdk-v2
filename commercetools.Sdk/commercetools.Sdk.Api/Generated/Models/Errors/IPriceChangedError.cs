using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.PriceChangedError))]
    public partial interface IPriceChangedError : IErrorObject
    {
        List<string> LineItems { get; set;}
        
        bool Shipping { get; set;}
    }
}
