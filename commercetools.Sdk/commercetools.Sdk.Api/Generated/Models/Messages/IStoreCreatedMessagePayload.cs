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
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.StoreCreatedMessagePayload))]
    public partial interface IStoreCreatedMessagePayload : IMessagePayload
    {
        ILocalizedString Name { get; set;}
        
        List<string> Languages { get; set;}
        
        List<IChannelReference> DistributionChannels { get; set;}
        
        List<IChannelReference> SupplyChannels { get; set;}
        
        ICustomFields Custom { get; set;}
    }
}
