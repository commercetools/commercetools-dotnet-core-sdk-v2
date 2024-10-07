using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.StoreCountries;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
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

        IList<string> Languages { get; set; }

        IEnumerable<string> LanguagesEnumerable { set => Languages = value.ToList(); }

        IList<IStoreCountry> Countries { get; set; }

        IEnumerable<IStoreCountry> CountriesEnumerable { set => Countries = value.ToList(); }

        IList<IChannelReference> DistributionChannels { get; set; }

        IEnumerable<IChannelReference> DistributionChannelsEnumerable { set => DistributionChannels = value.ToList(); }

        IList<IChannelReference> SupplyChannels { get; set; }

        IEnumerable<IChannelReference> SupplyChannelsEnumerable { set => SupplyChannels = value.ToList(); }

        IList<IProductSelectionSetting> ProductSelections { get; set; }

        IEnumerable<IProductSelectionSetting> ProductSelectionsEnumerable { set => ProductSelections = value.ToList(); }

        ICustomFields Custom { get; set; }

    }
}
