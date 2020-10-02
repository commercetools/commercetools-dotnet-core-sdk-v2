using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("changeDescription")]
    public partial class ChannelChangeDescriptionAction : ChannelUpdateAction
    {
        public LocalizedString Description { get; set;}
        public ChannelChangeDescriptionAction()
        { 
           this.Action = "changeDescription";
        }
    }
}
