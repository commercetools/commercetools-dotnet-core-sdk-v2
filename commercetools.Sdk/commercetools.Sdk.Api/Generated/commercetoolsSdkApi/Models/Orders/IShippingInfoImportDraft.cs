using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.ShippingInfoImportDraft))]
    public partial interface IShippingInfoImportDraft
    {
        string ShippingMethodName { get; set; }

        IMoney Price { get; set; }

        IShippingRateDraft ShippingRate { get; set; }

        ITaxRate TaxRate { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        IList<IDeliveryDraft> Deliveries { get; set; }

        IEnumerable<IDeliveryDraft> DeliveriesEnumerable { set => Deliveries = value.ToList(); }

        IDiscountedLineItemPriceDraft DiscountedPrice { get; set; }

        IShippingMethodState ShippingMethodState { get; set; }

    }
}
