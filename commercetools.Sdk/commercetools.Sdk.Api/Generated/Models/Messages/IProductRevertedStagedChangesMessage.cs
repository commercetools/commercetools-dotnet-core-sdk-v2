using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductRevertedStagedChangesMessage))]
    public partial interface IProductRevertedStagedChangesMessage : IMessage
    {
        List<string> RemovedImageUrls { get; set;}
    }
}
