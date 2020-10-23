using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ProductDiscounts
{
    public interface IProductDiscount : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        ILocalizedString Name { get; set;}
        
        string Key { get; set;}
        
        ILocalizedString Description { get; set;}
        
        IProductDiscountValue Value { get; set;}
        
        string Predicate { get; set;}
        
        string SortOrder { get; set;}
        
        bool IsActive { get; set;}
        
        List<IReference> References { get; set;}
        
        DateTime ValidFrom { get; set;}
        
        DateTime ValidUntil { get; set;}
    }
}
