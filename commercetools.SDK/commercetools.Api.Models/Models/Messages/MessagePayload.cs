using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [Discriminator(nameof(Type))]
    public abstract class MessagePayload 
    {
        public string Type { get; set;}
    }
}
