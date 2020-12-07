using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscount : ICartDiscount
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public ILastModifiedBy LastModifiedBy { get; set;}
        
        public ICreatedBy CreatedBy { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public string Key { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public ICartDiscountValueDraft Value { get; set;}
        
        public string CartPredicate { get; set;}
        
        public ICartDiscountTarget Target { get; set;}
        
        public string SortOrder { get; set;}
        
        public bool IsActive { get; set;}
        
        public DateTime ValidFrom { get; set;}
        
        public DateTime ValidUntil { get; set;}
        
        public bool RequiresDiscountCode { get; set;}
        
        public List<IReference> References { get; set;}
        
        public string StackingMode { get; set;}
        
        [JsonIgnore]
        public StackingMode StackingModeAsEnum => this.StackingMode.GetEnum<StackingMode>();
        
        public ICustomFields Custom { get; set;}
    }
}
