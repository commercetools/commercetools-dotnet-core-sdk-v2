using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductImageAddedMessage))]
    public partial interface IProductImageAddedMessage : IMessage
    {
        long VariantId { get; set;}
        
        IImage Image { get; set;}
        
        bool Staged { get; set;}
    }
}
