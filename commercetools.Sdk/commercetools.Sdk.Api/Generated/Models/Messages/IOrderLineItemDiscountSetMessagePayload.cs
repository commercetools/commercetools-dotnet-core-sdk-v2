using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderLineItemDiscountSetMessagePayload))]
    public partial interface IOrderLineItemDiscountSetMessagePayload : IOrderMessagePayload
    {
        string LineItemId { get; set; }

        List<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }

        IMoney TotalPrice { get; set; }

        ITaxedItemPrice TaxedPrice { get; set; }
    }
}
