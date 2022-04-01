using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceDiscountsSetMessagePayload))]
    public partial interface IProductPriceDiscountsSetMessagePayload : IMessagePayload
    {
        List<IProductPriceDiscountsSetUpdatedPrice> UpdatedPrices { get; set; }
    }
}
