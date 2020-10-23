using commercetools.Api.Generated.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Errors
{
    public interface IDiscountCodeNonApplicableError : IErrorObject
    {
        string DiscountCode { get; set;}
        
        string Reason { get; set;}
        
        string DicountCodeId { get; set;}
        
        DateTime ValidFrom { get; set;}
        
        DateTime ValidUntil { get; set;}
        
        DateTime ValidityCheckTime { get; set;}
    }
}
