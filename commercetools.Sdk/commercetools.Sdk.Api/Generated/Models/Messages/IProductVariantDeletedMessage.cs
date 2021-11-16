using commercetools.Api.Models.Products;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductVariantDeletedMessage))]
    public partial interface IProductVariantDeletedMessage : IMessage
    {
        IProductVariant Variant { get; set; }

        List<string> RemovedImageUrls { get; set; }
    }
}
