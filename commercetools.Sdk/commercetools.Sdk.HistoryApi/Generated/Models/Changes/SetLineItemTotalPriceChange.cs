using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetLineItemTotalPriceChange : ISetLineItemTotalPriceChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ILocalizedString LineItem { get; set;}
        
        public IMoney NextValue { get; set;}
        
        public IMoney PreviousValue { get; set;}
        public SetLineItemTotalPriceChange()
        { 
           this.Type = "SetLineItemTotalPriceChange";
        }
    }
}
