using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ShippingDraft))]
    public partial interface IShippingDraft
    {
        string Key { get; set; }

        IShippingMethodReference ShippingMethod { get; set; }

        IBaseAddress ShippingAddress { get; set; }

        IShippingRateInputDraft ShippingRateInput { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        IList<IDeliveryDraft> Deliveries { get; set; }
        IEnumerable<IDeliveryDraft> DeliveriesEnumerable { set => Deliveries = value.ToList(); }


        ICustomFieldsDraft Custom { get; set; }

    }
}
