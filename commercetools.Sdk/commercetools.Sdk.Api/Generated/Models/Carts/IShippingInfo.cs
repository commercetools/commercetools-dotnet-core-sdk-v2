using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ShippingInfo))]
    public partial interface IShippingInfo
    {
        string ShippingMethodName { get; set; }

        ITypedMoney Price { get; set; }

        IShippingRate ShippingRate { get; set; }

        ITaxedItemPrice TaxedPrice { get; set; }

        ITaxRate TaxRate { get; set; }

        ITaxCategoryReference TaxCategory { get; set; }

        IShippingMethodReference ShippingMethod { get; set; }

        List<IDelivery> Deliveries { get; set; }

        IDiscountedLineItemPrice DiscountedPrice { get; set; }

        IShippingMethodState ShippingMethodState { get; set; }

    }
}
