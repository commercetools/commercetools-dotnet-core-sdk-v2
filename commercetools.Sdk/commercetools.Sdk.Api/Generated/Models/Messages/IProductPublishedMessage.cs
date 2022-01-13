using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Products;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductPublishedMessage))]
    public partial interface IProductPublishedMessage : IMessage
    {
        List<string> RemovedImageUrls { get; set; }

        IProductProjection ProductProjection { get; set; }

        IProductPublishScope Scope { get; set; }
    }
}
