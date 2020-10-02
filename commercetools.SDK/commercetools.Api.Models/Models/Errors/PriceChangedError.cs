using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("PriceChanged")]
    public partial class PriceChangedError : ErrorObject
    {
        public List<string> LineItems { get; set;}
        
        public bool Shipping { get; set;}
        public PriceChangedError()
        { 
           this.Code = "PriceChanged";
        }
    }
}
