using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductPublishedMessagePayload))]
    public interface IProductPublishedMessagePayload : IMessagePayload
    {
        List<Object> RemovedImageUrls { get; set;}
        
        IProductProjection ProductProjection { get; set;}
        
        string Scope { get; set;}
        
        ProductPublishScope ScopeAsEnum { get; }
    }
}
