using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceDiscountsSetMessage))]
    public partial interface IProductPriceDiscountsSetMessage : IMessage
    {
        List<IProductPriceDiscountsSetUpdatedPrice> UpdatedPrices { get; set; }
    }
}
