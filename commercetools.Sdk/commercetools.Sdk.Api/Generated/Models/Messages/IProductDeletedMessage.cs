using commercetools.Api.Models.Products;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductDeletedMessage))]
    public partial interface IProductDeletedMessage : IMessage
    {
        List<string> RemovedImageUrls { get; set;}
        
        IProductProjection CurrentProjection { get; set;}
    }
}
