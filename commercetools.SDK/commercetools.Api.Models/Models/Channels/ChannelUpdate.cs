using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    public partial class ChannelUpdate 
    {
        public long Version { get; set;}
        
        public List<ChannelUpdateAction> Actions { get; set;}
    }
}
