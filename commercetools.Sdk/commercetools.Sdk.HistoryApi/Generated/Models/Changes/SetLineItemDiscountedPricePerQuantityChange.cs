using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetLineItemDiscountedPricePerQuantityChange : ISetLineItemDiscountedPricePerQuantityChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ILocalizedString LineItem { get; set;}
        
        public string Variant { get; set;}
        
        public IDiscountedLineItemPriceForQuantity NextValue { get; set;}
        
        public IDiscountedLineItemPriceForQuantity PreviousValue { get; set;}
        public SetLineItemDiscountedPricePerQuantityChange()
        { 
           this.Type = "SetLineItemDiscountedPricePerQuantityChange";
        }
    }
}
