using commercetools.Api.Generated.Models.Carts;
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
    public interface IProductPublishedMessage : IMessage
    {
        List<Object> RemovedImageUrls { get; set;}
        
        IProductProjection ProductProjection { get; set;}
        
        string Scope { get; set;}
        
        ProductPublishScope ScopeAsEnum { get; }
    }
}
