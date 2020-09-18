using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public class ItemShippingDetailsDraft 
    {
        public List<ItemShippingTarget> Targets { get; set;}
    }
}
