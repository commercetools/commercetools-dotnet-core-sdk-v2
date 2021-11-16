using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductPriceDiscountsSetMessagePayload))]
    public partial interface IProductPriceDiscountsSetMessagePayload : IMessagePayload
    {
        List<IProductPriceDiscountsSetUpdatedPrice> UpdatedPrices { get; set; }
    }
}
