using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductVariantDeletedMessagePayload))]
    public partial interface IProductVariantDeletedMessagePayload : IMessagePayload
    {
        IProductVariant Variant { get; set; }

        IList<string> RemovedImageUrls { get; set; }

        IEnumerable<string> RemovedImageUrlsEnumerable { set => RemovedImageUrls = value.ToList(); }

        bool Staged { get; set; }

    }
}
