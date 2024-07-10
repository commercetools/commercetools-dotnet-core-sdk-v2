using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodAction))]
    public partial interface IStagedOrderSetShippingMethodAction : IStagedOrderUpdateAction
    {
        IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

    }
}
