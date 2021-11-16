using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class ChangeValueGiftLineItemChangeValue : IChangeValueGiftLineItemChangeValue
    {
        public string Type { get; set;}
        
        public IReference Product { get; set;}
        
        public int VariantId { get; set;}
        
        public IReference SupplyChannel { get; set;}
        
        public IReference DistributionChannel { get; set;}
        public ChangeValueGiftLineItemChangeValue()
        { 
           this.Type = "giftLineItem";
        }
    }
}
