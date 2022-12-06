using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Prices;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.ShippingInfoImportDraft))]
    public partial interface IShippingInfoImportDraft
    {
        string ShippingMethodName { get; set; }

        ITypedMoney Price { get; set; }

        IShippingRateDraft ShippingRate { get; set; }

        ITaxRate TaxRate { get; set; }

        ITaxCategoryKeyReference TaxCategory { get; set; }

        IShippingMethodKeyReference ShippingMethod { get; set; }

        IList<IDelivery> Deliveries { get; set; }
        IEnumerable<IDelivery> DeliveriesEnumerable { set => Deliveries = value.ToList(); }


        IDiscountedLineItemPriceDraft DiscountedPrice { get; set; }

        IShippingMethodState ShippingMethodState { get; set; }

    }
}
