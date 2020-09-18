using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("changeName")]
    public class ChannelChangeNameAction : ChannelUpdateAction
    {
        public LocalizedString Name { get; set;}
    }
}
