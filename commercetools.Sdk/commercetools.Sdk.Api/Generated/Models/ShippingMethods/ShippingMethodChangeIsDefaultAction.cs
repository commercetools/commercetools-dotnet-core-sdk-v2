using commercetools.Sdk.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethodChangeIsDefaultAction : IShippingMethodChangeIsDefaultAction
    {
        public string Action { get; set; }

        public bool IsDefault { get; set; }
        public ShippingMethodChangeIsDefaultAction()
        {
            this.Action = "changeIsDefault";
        }
    }
}
