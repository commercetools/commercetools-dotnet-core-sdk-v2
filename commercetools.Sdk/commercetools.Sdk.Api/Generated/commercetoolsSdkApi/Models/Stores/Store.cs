using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.StoreCountries;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IList<string> Languages { get; set; }

        public IEnumerable<string> LanguagesEnumerable { set => Languages = value.ToList(); }

        public IList<IStoreCountry> Countries { get; set; }

        public IEnumerable<IStoreCountry> CountriesEnumerable { set => Countries = value.ToList(); }

        public IList<IChannelReference> DistributionChannels { get; set; }

        public IEnumerable<IChannelReference> DistributionChannelsEnumerable { set => DistributionChannels = value.ToList(); }

        public IList<IChannelReference> SupplyChannels { get; set; }

        public IEnumerable<IChannelReference> SupplyChannelsEnumerable { set => SupplyChannels = value.ToList(); }

        public IList<IProductSelectionSetting> ProductSelections { get; set; }

        public IEnumerable<IProductSelectionSetting> ProductSelectionsEnumerable { set => ProductSelections = value.ToList(); }

        public ICustomFields Custom { get; set; }
    }
}
