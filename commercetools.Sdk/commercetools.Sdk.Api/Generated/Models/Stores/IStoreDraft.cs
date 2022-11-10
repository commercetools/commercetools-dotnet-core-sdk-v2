using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.StoreCountries;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreDraft))]
    public partial interface IStoreDraft
    {
        string Key { get; set; }

        ILocalizedString Name { get; set; }

        List<string> Languages { get; set; }

        List<IStoreCountry> Countries { get; set; }

        List<IChannelResourceIdentifier> DistributionChannels { get; set; }

        List<IChannelResourceIdentifier> SupplyChannels { get; set; }

        List<IProductSelectionSettingDraft> ProductSelections { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
