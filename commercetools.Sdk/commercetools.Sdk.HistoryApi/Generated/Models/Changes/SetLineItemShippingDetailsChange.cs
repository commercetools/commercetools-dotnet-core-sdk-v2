using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetLineItemShippingDetailsChange : ISetLineItemShippingDetailsChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public string LineItemId { get; set;}
        
        public IItemShippingDetails NextValue { get; set;}
        
        public IItemShippingDetails PreviousValue { get; set;}
        public SetLineItemShippingDetailsChange()
        { 
           this.Type = "SetLineItemShippingDetailsChange";
        }
    }
}
