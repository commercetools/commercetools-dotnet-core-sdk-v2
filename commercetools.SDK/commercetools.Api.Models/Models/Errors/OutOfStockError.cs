using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("OutOfStock")]
    public class OutOfStockError : ErrorObject
    {
        public List<string> LineItems { get; set;}
        
        public List<string> Skus { get; set;}
    }
}
