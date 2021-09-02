using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodChangeNameAction : IShippingMethodChangeNameAction
    {
        public string Action { get; set; }

        public string Name { get; set; }
        public ShippingMethodChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
