using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class DeliveryChangeValue : IDeliveryChangeValue
    {
        public List<IDeliveryItem> Items { get; set;}
        
        public IAddress Address { get; set;}
        
        public List<IParcel> Parcels { get; set;}
    }
}
