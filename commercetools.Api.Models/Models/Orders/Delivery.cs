using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class Delivery 
    {
        public string Id { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public List<DeliveryItem> Items { get; set;}
        
        public List<Parcel> Parcels { get; set;}
        
        public Address Address { get; set;}
    }
}
