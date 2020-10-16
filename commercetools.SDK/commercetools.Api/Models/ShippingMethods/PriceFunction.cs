using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class PriceFunction 
    {
        public string CurrencyCode { get; set;}
        
        public string Function { get; set;}
    }
}
