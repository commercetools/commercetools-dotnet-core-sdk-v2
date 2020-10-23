using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    public  partial class StoreDraft : IStoreDraft
    {
        public string Key { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public List<string> Languages { get; set;}
        
        public List<IChannelResourceIdentifier> DistributionChannels { get; set;}
        
        public List<IChannelResourceIdentifier> SupplyChannels { get; set;}
    }
}
