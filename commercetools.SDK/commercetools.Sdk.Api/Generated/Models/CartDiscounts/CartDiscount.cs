using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscount : BaseResource
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
        
        public CartDiscountValue Value { get; set;}
        
        public string CartPredicate { get; set;}
        
        public CartDiscountTarget Target { get; set;}
        
        public string SortOrder { get; set;}
        
        public bool IsActive { get; set;}
        
        public DateTime ValidFrom { get; set;}
        
        public DateTime ValidUntil { get; set;}
        
        public bool RequiresDiscountCode { get; set;}
        
        public List<Reference> References { get; set;}
        
        public string StackingMode { get; set;}
        
        [JsonIgnore]
        public StackingMode StackingModeAsEnum => this.StackingMode.GetEnum<StackingMode>();
        
        public CustomFields Custom { get; set;}
    }
}
