using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [Discriminator(nameof(Action))]
    public abstract class ChannelUpdateAction 
    {
        public string Action { get; set;}
    }
}
