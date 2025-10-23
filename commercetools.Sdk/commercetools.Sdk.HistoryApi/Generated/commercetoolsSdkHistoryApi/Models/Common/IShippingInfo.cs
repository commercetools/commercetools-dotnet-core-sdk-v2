using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ShippingInfo))]
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
