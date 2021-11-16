using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetParcelItemsChange : ISetParcelItemsChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IParcelChangeValue Parcel { get; set;}
        
        public List<IDeliveryItem> NextValue { get; set;}
        
        public List<IDeliveryItem> PreviousValue { get; set;}
        public SetParcelItemsChange()
        { 
           this.Type = "SetParcelItemsChange";
        }
    }
}
