using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ShippingInfo))]
    public partial interface IShippingInfo
    {
        string ShippingMethodName { get; set; }

        ICentPrecisionMoney Price { get; set; }

        IShippingRate ShippingRate { get; set; }

        ITaxedItemPrice TaxedPrice { get; set; }

        ITaxRate TaxRate { get; set; }

        ITaxCategoryReference TaxCategory { get; set; }

        IShippingMethodReference ShippingMethod { get; set; }

        IList<IDelivery> Deliveries { get; set; }

        IEnumerable<IDelivery> DeliveriesEnumerable { set => Deliveries = value.ToList(); }

        IDiscountedLineItemPrice DiscountedPrice { get; set; }

        IShippingMethodState ShippingMethodState { get; set; }

    }
}
