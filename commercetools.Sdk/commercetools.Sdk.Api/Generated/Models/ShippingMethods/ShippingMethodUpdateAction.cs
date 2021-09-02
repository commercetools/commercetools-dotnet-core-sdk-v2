using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodUpdateAction : IShippingMethodUpdateAction
    {
        public string Action { get; set; }
    }
}
