using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductRevertedStagedChangesMessagePayload))]
    public partial interface IProductRevertedStagedChangesMessagePayload : IMessagePayload
    {
        List<string> RemovedImageUrls { get; set; }

    }
}
