using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Channels
{
    public class ChannelSetCustomFieldAction : ChannelUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
