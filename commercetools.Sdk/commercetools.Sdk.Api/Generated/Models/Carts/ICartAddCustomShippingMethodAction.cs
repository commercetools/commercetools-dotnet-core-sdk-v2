using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartAddCustomShippingMethodAction))]
    public partial interface ICartAddCustomShippingMethodAction : ICartUpdateAction
    {
        string ShippingKey { get; set; }

        string ShippingMethodName { get; set; }

        IBaseAddress ShippingAddress { get; set; }

        IShippingRateDraft ShippingRate { get; set; }

        IShippingRateInputDraft ShippingRateInput { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        IList<IDeliveryDraft> Deliveries { get; set; }
        IEnumerable<IDeliveryDraft> DeliveriesEnumerable { set => Deliveries = value.ToList(); }


        ICustomFieldsDraft Custom { get; set; }

    }
}
