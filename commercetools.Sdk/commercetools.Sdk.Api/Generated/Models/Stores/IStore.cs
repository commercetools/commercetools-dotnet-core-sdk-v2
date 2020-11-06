using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.Store))]
    public partial interface IStore : IBaseResource
    {
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        string Key { get; set;}
        
        ILocalizedString Name { get; set;}
        
        List<string> Languages { get; set;}
        
        List<IChannelReference> DistributionChannels { get; set;}
        
        List<IChannelReference> SupplyChannels { get; set;}
    }
}
