using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class Delivery : IDelivery
    {
        public string Id { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public List<IDeliveryItem> Items { get; set;}
        
        public List<IParcel> Parcels { get; set;}
        
        public IAddress Address { get; set;}
    }
}
