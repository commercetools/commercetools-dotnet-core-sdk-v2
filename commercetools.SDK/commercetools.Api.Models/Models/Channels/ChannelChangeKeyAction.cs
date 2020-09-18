using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("changeKey")]
    public class ChannelChangeKeyAction : ChannelUpdateAction
    {
        public string Key { get; set;}
    }
}
