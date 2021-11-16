using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreDraft))]
    public partial interface IStoreDraft
    {
        string Key { get; set; }

        ILocalizedString Name { get; set; }

        List<string> Languages { get; set; }

        List<IChannelResourceIdentifier> DistributionChannels { get; set; }

        List<IChannelResourceIdentifier> SupplyChannels { get; set; }

        ICustomFieldsDraft Custom { get; set; }
    }
}
