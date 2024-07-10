using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetShippingAddressAndShippingMethodAction : IStagedOrderSetShippingAddressAndShippingMethodAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }

        public IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }
        public StagedOrderSetShippingAddressAndShippingMethodAction()
        {
            this.Action = "setShippingAddressAndShippingMethod";
        }
    }
}
