using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Stores
{
    public class StoreDraft 
    {
        public string Key { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public List<string> Languages { get; set;}
        
        public List<ChannelResourceIdentifier> DistributionChannels { get; set;}
        
        public List<ChannelResourceIdentifier> SupplyChannels { get; set;}
    }
}
