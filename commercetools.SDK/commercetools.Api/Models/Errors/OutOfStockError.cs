using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("OutOfStock")]
    public partial class OutOfStockError : ErrorObject
    {
        public List<string> LineItems { get; set;}
        
        public List<string> Skus { get; set;}
        public OutOfStockError()
        { 
           this.Code = "OutOfStock";
        }
    }
}
