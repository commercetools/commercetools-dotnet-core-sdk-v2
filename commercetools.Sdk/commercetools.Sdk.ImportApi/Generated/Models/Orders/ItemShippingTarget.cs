using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class ItemShippingTarget : IItemShippingTarget
    {
        public string AddressKey { get; set;}
        
        public double Quantity { get; set;}
    }
}
