using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Stores
{
    public partial class Store : IStore
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public List<string> Languages { get; set; }

        public List<IChannelReference> DistributionChannels { get; set; }

        public List<IChannelReference> SupplyChannels { get; set; }

        public List<IProductSelectionSetting> ProductSelections { get; set; }

        public ICustomFields Custom { get; set; }
    }
}
