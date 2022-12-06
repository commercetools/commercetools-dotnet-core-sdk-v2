using commercetools.Sdk.Api.Models.Carts;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemDiscountSetMessage))]
    public partial interface IOrderCustomLineItemDiscountSetMessage : IOrderMessage
    {
        string CustomLineItemId { get; set; }

        IList<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set; }
        IEnumerable<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantityEnumerable { set => DiscountedPricePerQuantity = value.ToList(); }


        ITaxedItemPrice TaxedPrice { get; set; }

    }
}
