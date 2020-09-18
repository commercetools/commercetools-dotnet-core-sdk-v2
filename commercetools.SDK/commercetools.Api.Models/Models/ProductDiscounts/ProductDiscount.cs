using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    public class ProductDiscount : BaseResource
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public LastModifiedBy LastModifiedBy { get; set;}
        
        public CreatedBy CreatedBy { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public string Key { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public ProductDiscountValue Value { get; set;}
        
        public string Predicate { get; set;}
        
        public string SortOrder { get; set;}
        
        public bool IsActive { get; set;}
        
        public List<Reference> References { get; set;}
        
        public DateTime ValidFrom { get; set;}
        
        public DateTime ValidUntil { get; set;}
    }
}
