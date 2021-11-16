using commercetools.Api.Models.Products;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductVariantDeletedMessagePayload))]
    public partial interface IProductVariantDeletedMessagePayload : IMessagePayload
    {
        IProductVariant Variant { get; set;}
        
        List<string> RemovedImageUrls { get; set;}
    }
}
