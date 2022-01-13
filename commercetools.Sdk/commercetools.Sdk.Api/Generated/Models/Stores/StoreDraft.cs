using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Api.Models.Stores
{
    public partial class StoreDraft : IStoreDraft
    {
        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public List<string> Languages { get; set; }

        public List<IChannelResourceIdentifier> DistributionChannels { get; set; }

        public List<IChannelResourceIdentifier> SupplyChannels { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
