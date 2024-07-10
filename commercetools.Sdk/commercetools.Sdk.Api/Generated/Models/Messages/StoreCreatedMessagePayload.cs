using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.StoreCountries;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreCreatedMessagePayload : IStoreCreatedMessagePayload
    {
        public string Type { get; set; }

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
        public StoreCreatedMessagePayload()
        {
            this.Type = "StoreCreated";
        }
    }
}
