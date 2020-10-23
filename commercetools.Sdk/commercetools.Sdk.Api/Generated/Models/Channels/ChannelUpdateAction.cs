using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    public abstract partial class ChannelUpdateAction : IChannelUpdateAction
    {
        public string Action { get; set;}
    }
}
