using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductDeletedMessagePayload))]
    public partial interface IProductDeletedMessagePayload : IMessagePayload
    {
        IList<string> RemovedImageUrls { get; set; }
        IEnumerable<string> RemovedImageUrlsEnumerable { set => RemovedImageUrls = value.ToList(); }


        IProductProjection CurrentProjection { get; set; }

    }
}
