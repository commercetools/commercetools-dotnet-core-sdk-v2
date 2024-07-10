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

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreDraft))]
    public partial interface IStoreDraft
    {
        string Key { get; set; }

        ILocalizedString Name { get; set; }

        IList<string> Languages { get; set; }
        IEnumerable<string> LanguagesEnumerable { set => Languages = value.ToList(); }


        IList<IStoreCountry> Countries { get; set; }
        IEnumerable<IStoreCountry> CountriesEnumerable { set => Countries = value.ToList(); }


        IList<IChannelResourceIdentifier> DistributionChannels { get; set; }
        IEnumerable<IChannelResourceIdentifier> DistributionChannelsEnumerable { set => DistributionChannels = value.ToList(); }


        IList<IChannelResourceIdentifier> SupplyChannels { get; set; }
        IEnumerable<IChannelResourceIdentifier> SupplyChannelsEnumerable { set => SupplyChannels = value.ToList(); }


        IList<IProductSelectionSettingDraft> ProductSelections { get; set; }
        IEnumerable<IProductSelectionSettingDraft> ProductSelectionsEnumerable { set => ProductSelections = value.ToList(); }


        ICustomFieldsDraft Custom { get; set; }

    }
}
