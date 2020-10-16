using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Carts
{
    public partial class ItemShippingDetailsDraft 
    {
        public List<ItemShippingTarget> Targets { get; set;}
    }
}
