using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("changeKey")]
    public partial class ChannelChangeKeyAction : ChannelUpdateAction
    {
        public string Key { get; set;}
        public ChannelChangeKeyAction()
        { 
           this.Action = "changeKey";
        }
    }
}
