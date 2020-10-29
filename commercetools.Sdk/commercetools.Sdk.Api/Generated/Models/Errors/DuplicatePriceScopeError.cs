using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class DuplicatePriceScopeError : IDuplicatePriceScopeError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public List<IPrice> ConflictingPrices { get; set;}
        public DuplicatePriceScopeError()
        { 
           this.Code = "DuplicatePriceScope";
        }
    }
}
