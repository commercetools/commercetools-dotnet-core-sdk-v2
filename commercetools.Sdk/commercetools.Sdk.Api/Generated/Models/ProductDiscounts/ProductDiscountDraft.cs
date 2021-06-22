using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountDraft : IProductDiscountDraft
    {
        public ILocalizedString Name { get; set;}
        
        public string Key { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public IProductDiscountValueDraft Value { get; set;}
        
        public string Predicate { get; set;}
        
        public string SortOrder { get; set;}
        
        public bool IsActive { get; set;}
        
        public DateTime? ValidFrom { get; set;}
        
        public DateTime? ValidUntil { get; set;}
    }
}
