using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductVariantDeletedMessagePayload))]
    public partial interface IProductVariantDeletedMessagePayload : IMessagePayload
    {
        IProductVariant Variant { get; set; }

        List<string> RemovedImageUrls { get; set; }

    }
}
