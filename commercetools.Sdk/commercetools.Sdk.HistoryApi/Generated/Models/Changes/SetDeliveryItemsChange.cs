using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetDeliveryItemsChange : ISetDeliveryItemsChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public string DeliveryId { get; set;}
        
        public List<IDeliveryItem> NextValue { get; set;}
        
        public List<IDeliveryItem> PreviousValue { get; set;}
        public SetDeliveryItemsChange()
        { 
           this.Type = "SetDeliveryItemsChange";
        }
    }
}
