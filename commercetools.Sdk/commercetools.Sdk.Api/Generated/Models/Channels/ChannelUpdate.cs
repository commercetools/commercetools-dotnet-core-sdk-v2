using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    public  partial class ChannelUpdate : IChannelUpdate
    {
        public long Version { get; set;}
        
        public List<IChannelUpdateAction> Actions { get; set;}
    }
}
