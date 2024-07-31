using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPublishedMessage))]
    public partial interface IProductPublishedMessage : IMessage
    {
        IList<string> RemovedImageUrls { get; set; }

        IEnumerable<string> RemovedImageUrlsEnumerable { set => RemovedImageUrls = value.ToList(); }

        IProductProjection ProductProjection { get; set; }

        IProductPublishScope Scope { get; set; }

    }
}
