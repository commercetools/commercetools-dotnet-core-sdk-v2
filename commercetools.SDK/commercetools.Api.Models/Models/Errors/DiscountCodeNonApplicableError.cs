using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("DiscountCodeNonApplicable")]
    public class DiscountCodeNonApplicableError : ErrorObject
    {
        public string DiscountCode { get; set;}
        
        public string Reason { get; set;}
        
        public string DicountCodeId { get; set;}
        
        public DateTime ValidFrom { get; set;}
        
        public DateTime ValidUntil { get; set;}
        
        public DateTime ValidityCheckTime { get; set;}
    }
}
