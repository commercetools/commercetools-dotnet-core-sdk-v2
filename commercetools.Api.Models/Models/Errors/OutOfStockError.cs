using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Errors
{
    public class OutOfStockError : ErrorObject
    {
        public List<string> LineItems { get; set;}
        
        public List<string> Skus { get; set;}
    }
}
