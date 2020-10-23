using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductDeletedMessage))]
    public interface IProductDeletedMessage : IMessage
    {
        List<string> RemovedImageUrls { get; set;}
        
        IProductProjection CurrentProjection { get; set;}
    }
}
