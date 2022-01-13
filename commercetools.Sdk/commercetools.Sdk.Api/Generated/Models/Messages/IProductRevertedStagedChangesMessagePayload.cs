using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductRevertedStagedChangesMessagePayload))]
    public partial interface IProductRevertedStagedChangesMessagePayload : IMessagePayload
    {
        List<string> RemovedImageUrls { get; set; }
    }
}
