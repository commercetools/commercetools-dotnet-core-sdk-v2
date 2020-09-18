using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [Discriminator(nameof(Action))]
    public abstract class StagedOrderUpdateAction 
    {
        public string Action { get; set;}
    }
}
