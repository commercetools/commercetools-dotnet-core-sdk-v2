using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ShippingMethods
{
    public interface IPriceFunction 
    {
        string CurrencyCode { get; set;}
        
        string Function { get; set;}
    }
}
