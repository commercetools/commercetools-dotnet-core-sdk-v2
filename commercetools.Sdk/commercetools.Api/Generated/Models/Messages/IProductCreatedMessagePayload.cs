using commercetools.Api.Generated.Models.Messages;
using commercetools.Api.Generated.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IProductCreatedMessagePayload : IMessagePayload
    {
        IProductProjection ProductProjection { get; set;}
    }
}
