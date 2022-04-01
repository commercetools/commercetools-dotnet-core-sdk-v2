using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductRevertedStagedChangesMessage))]
    public partial interface IProductRevertedStagedChangesMessage : IMessage
    {
        List<string> RemovedImageUrls { get; set; }
    }
}
