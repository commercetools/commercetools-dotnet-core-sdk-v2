using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IProductImageAddedMessagePayload : IMessagePayload
    {
        long VariantId { get; set;}
        
        IImage Image { get; set;}
        
        bool Staged { get; set;}
    }
}
