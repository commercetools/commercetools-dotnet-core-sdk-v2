using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public  partial class ItemShippingDetails : IItemShippingDetails
    {
        public List<IItemShippingTarget> Targets { get; set;}
        
        public bool Valid { get; set;}
    }
}
