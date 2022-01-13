using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductPriceDiscountsSetMessage))]
    public partial interface IProductPriceDiscountsSetMessage : IMessage
    {
        List<IProductPriceDiscountsSetUpdatedPrice> UpdatedPrices { get; set; }
    }
}
