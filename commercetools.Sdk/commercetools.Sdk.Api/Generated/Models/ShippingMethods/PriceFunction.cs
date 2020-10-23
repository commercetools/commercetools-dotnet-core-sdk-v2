using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public  partial class PriceFunction : IPriceFunction
    {
        public string CurrencyCode { get; set;}
        
        public string Function { get; set;}
    }
}
