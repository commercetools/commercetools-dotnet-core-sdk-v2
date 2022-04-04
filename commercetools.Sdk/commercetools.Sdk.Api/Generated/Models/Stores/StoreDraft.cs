using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Stores
{
    public partial class StoreDraft : IStoreDraft
    {
        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public List<string> Languages { get; set; }

        public List<IChannelResourceIdentifier> DistributionChannels { get; set; }

        public List<IChannelResourceIdentifier> SupplyChannels { get; set; }

        public List<IProductSelectionSettingDraft> ProductSelections { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
