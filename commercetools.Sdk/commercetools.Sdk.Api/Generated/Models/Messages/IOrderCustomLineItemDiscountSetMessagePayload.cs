using commercetools.Api.Models.Carts;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderCustomLineItemDiscountSetMessagePayload))]
    public partial interface IOrderCustomLineItemDiscountSetMessagePayload : IMessagePayload
    {
        string CustomLineItemId { get; set;}
        
        List<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set;}
        
        ITaxedItemPrice TaxedPrice { get; set;}
    }
}
