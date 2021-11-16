using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class DeliveryChangeValue : IDeliveryChangeValue
    {
        public List<IDeliveryItem> Items { get; set;}
        
        public IAddress Address { get; set;}
        
        public List<IParcel> Parcels { get; set;}
    }
}
