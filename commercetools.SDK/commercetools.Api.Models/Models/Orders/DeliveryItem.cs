using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class DeliveryItem 
    {
        public string Id { get; set;}
        
        public double Quantity { get; set;}
    }
}
