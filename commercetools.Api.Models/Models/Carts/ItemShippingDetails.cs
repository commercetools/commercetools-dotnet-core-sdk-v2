using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class ItemShippingDetails 
    {
        public List<ItemShippingTarget> Targets { get; set;}
        
        public bool Valid { get; set;}
    }
}
