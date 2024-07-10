using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Me;
using commercetools.Sdk.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartSetShippingMethodAction))]
    public partial interface IMyCartSetShippingMethodAction : IMyCartUpdateAction
    {
        IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

    }
}
