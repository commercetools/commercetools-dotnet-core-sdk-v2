using commercetools.Api.Generated.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Errors
{
    public interface IOutOfStockError : IErrorObject
    {
        List<string> LineItems { get; set;}
        
        List<string> Skus { get; set;}
    }
}
