using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ProductDiscounts
{
    public interface IProductDiscountDraft 
    {
        ILocalizedString Name { get; set;}
        
        string Key { get; set;}
        
        ILocalizedString Description { get; set;}
        
        IProductDiscountValueDraft Value { get; set;}
        
        string Predicate { get; set;}
        
        string SortOrder { get; set;}
        
        bool IsActive { get; set;}
        
        DateTime ValidFrom { get; set;}
        
        DateTime ValidUntil { get; set;}
    }
}
