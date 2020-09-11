using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Channels
{
    public class ChannelUpdate 
    {
        public long Version { get; set;}
        
        public List<ChannelUpdateAction> Actions { get; set;}
    }
}
