using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.Store))]
    public partial interface IStore : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string Key { get; set; }

        ILocalizedString Name { get; set; }

        List<string> Languages { get; set; }

        List<IChannelReference> DistributionChannels { get; set; }

        List<IChannelReference> SupplyChannels { get; set; }

        List<IProductSelectionSetting> ProductSelections { get; set; }

        ICustomFields Custom { get; set; }
    }
}
