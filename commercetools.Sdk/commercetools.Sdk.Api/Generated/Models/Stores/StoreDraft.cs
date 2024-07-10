using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.StoreCountries;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreDraft : IStoreDraft
    {
        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public IList<string> Languages { get; set; }
        public IEnumerable<string> LanguagesEnumerable { set => Languages = value.ToList(); }


        public IList<IStoreCountry> Countries { get; set; }
        public IEnumerable<IStoreCountry> CountriesEnumerable { set => Countries = value.ToList(); }


        public IList<IChannelResourceIdentifier> DistributionChannels { get; set; }
        public IEnumerable<IChannelResourceIdentifier> DistributionChannelsEnumerable { set => DistributionChannels = value.ToList(); }


        public IList<IChannelResourceIdentifier> SupplyChannels { get; set; }
        public IEnumerable<IChannelResourceIdentifier> SupplyChannelsEnumerable { set => SupplyChannels = value.ToList(); }


        public IList<IProductSelectionSettingDraft> ProductSelections { get; set; }
        public IEnumerable<IProductSelectionSettingDraft> ProductSelectionsEnumerable { set => ProductSelections = value.ToList(); }


        public ICustomFieldsDraft Custom { get; set; }
    }
}
