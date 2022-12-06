using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.StoreCountries;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreCreatedMessage))]
    public partial interface IStoreCreatedMessage : IMessage
    {
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
