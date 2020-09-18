using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public class CartDiscountDraft 
    {
        public LocalizedString Name { get; set;}
        
        public string Key { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public CartDiscountValueDraft Value { get; set;}
        
        public string CartPredicate { get; set;}
        
        public CartDiscountTarget Target { get; set;}
        
        public string SortOrder { get; set;}
        
        public bool IsActive { get; set;}
        
        public DateTime ValidFrom { get; set;}
        
        public DateTime ValidUntil { get; set;}
        
        public bool RequiresDiscountCode { get; set;}
        
        public string StackingMode { get; set;}
        
        public StackingMode StackingModeAsEnum => this.StackingMode.GetEnum<StackingMode>();
        
        public CustomFields Custom { get; set;}
    }
}
