using commercetools.Sdk.Api.Models.Carts;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemDiscountSetMessage))]
    public partial interface IOrderCustomLineItemDiscountSetMessage : IOrderMessage
    {
        string CustomLineItemId { get; set; }

        List<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }

        ITaxedItemPrice TaxedPrice { get; set; }
    }
}
