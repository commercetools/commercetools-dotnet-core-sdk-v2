using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Errors
{
    public class PriceChangedError : ErrorObject
    {
        public List<string> LineItems { get; set;}
        
        public bool Shipping { get; set;}
    }
}
