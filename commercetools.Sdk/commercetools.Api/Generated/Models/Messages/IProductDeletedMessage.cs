using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Messages;
using commercetools.Api.Generated.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IProductDeletedMessage : IMessage
    {
        List<string> RemovedImageUrls { get; set;}
        
        IProductProjection CurrentProjection { get; set;}
    }
}
