using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Me;
using commercetools.Sdk.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartSetShippingMethodAction : IMyCartSetShippingMethodAction
    {
        public string Action { get; set; }

        public IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }
        public MyCartSetShippingMethodAction()
        {
            this.Action = "setShippingMethod";
        }
    }
}
