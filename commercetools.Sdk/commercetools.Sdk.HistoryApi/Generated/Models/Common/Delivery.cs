using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class Delivery : IDelivery
    {
        public string Id { get; set;}
        
        public string CreatedAt { get; set;}
        
        public List<IDeliveryItem> Items { get; set;}
        
        public List<IParcel> Parcels { get; set;}
        
        public IAddress Address { get; set;}
    }
}
