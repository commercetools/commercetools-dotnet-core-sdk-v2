using commercetools.Api.Generated.Models.Channels;
using commercetools.Api.Generated.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Stores
{
    public interface IStore : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        string Key { get; set;}
        
        ILocalizedString Name { get; set;}
        
        List<string> Languages { get; set;}
        
        List<IChannelReference> DistributionChannels { get; set;}
        
        List<IChannelResourceIdentifier> SupplyChannels { get; set;}
    }
}
