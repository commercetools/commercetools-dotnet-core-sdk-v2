using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.StoreCountries;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreCreatedMessagePayload))]
    public partial interface IStoreCreatedMessagePayload : IMessagePayload
    {
        ILocalizedString Name { get; set; }

        List<string> Languages { get; set; }

        List<IStoreCountry> Countries { get; set; }

        List<IChannelReference> DistributionChannels { get; set; }

        List<IChannelReference> SupplyChannels { get; set; }

        List<IProductSelectionSetting> ProductSelections { get; set; }

        ICustomFields Custom { get; set; }

    }
}
