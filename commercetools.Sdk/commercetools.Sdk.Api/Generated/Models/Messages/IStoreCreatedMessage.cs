using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.StoreCreatedMessage))]
    public partial interface IStoreCreatedMessage : IMessage
    {
        ILocalizedString Name { get; set;}
        
        List<string> Languages { get; set;}
        
        List<IChannelReference> DistributionChannels { get; set;}
        
        List<IChannelReference> SupplyChannels { get; set;}
        
        ICustomFields Custom { get; set;}
    }
}
