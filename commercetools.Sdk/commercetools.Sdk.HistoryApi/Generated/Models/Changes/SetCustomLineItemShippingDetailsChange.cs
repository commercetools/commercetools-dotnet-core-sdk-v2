using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetCustomLineItemShippingDetailsChange : ISetCustomLineItemShippingDetailsChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public IItemShippingDetails NextValue { get; set;}
        
        public IItemShippingDetails PreviousValue { get; set;}
        public SetCustomLineItemShippingDetailsChange()
        { 
           this.Type = "SetCustomLineItemShippingDetailsChange";
        }
    }
}
