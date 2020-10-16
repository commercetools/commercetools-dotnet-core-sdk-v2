using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("channel")]
    public partial class ChannelResourceIdentifier : ResourceIdentifier
    {
        public ChannelResourceIdentifier()
        { 
           this.TypeId = "channel";
        }
    }
}
