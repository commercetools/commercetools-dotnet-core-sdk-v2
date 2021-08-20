using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class StoreCreatedMessagePayload : IStoreCreatedMessagePayload
    {
        public string Type { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public List<string> Languages { get; set;}
        
        public List<IChannelReference> DistributionChannels { get; set;}
        
        public List<IChannelReference> SupplyChannels { get; set;}
        
        public ICustomFields Custom { get; set;}
        public StoreCreatedMessagePayload()
        { 
           this.Type = "StoreCreated";
        }
    }
}
