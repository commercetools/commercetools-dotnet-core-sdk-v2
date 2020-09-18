using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [Discriminator(nameof(Action))]
    public abstract class OrderUpdateAction 
    {
        public string Action { get; set;}
    }
}
