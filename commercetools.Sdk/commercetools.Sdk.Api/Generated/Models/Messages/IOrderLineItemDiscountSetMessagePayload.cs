using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderLineItemDiscountSetMessagePayload))]
    public partial interface IOrderLineItemDiscountSetMessagePayload : IOrderMessagePayload
    {
        string LineItemId { get; set; }

        List<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }

        IMoney TotalPrice { get; set; }

        ITaxedItemPrice TaxedPrice { get; set; }

    }
}
