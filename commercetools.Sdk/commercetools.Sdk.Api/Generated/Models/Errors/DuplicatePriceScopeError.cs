using commercetools.Api.Models.Common;
using System.Collections.Generic;


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
