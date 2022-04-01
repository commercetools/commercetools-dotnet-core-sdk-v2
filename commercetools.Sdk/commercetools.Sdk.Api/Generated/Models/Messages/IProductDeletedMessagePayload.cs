using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductDeletedMessagePayload))]
    public partial interface IProductDeletedMessagePayload : IMessagePayload
    {
        List<string> RemovedImageUrls { get; set; }

        IProductProjection CurrentProjection { get; set; }
    }
}
