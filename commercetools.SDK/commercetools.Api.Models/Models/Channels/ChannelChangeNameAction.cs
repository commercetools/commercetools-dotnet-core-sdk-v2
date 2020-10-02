using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("changeName")]
    public partial class ChannelChangeNameAction : ChannelUpdateAction
    {
        public LocalizedString Name { get; set;}
        public ChannelChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}
