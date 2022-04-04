using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class StoreCreatedMessagePayload : IStoreCreatedMessagePayload
    {
        public string Type { get; set; }

        public ILocalizedString Name { get; set; }

        public List<string> Languages { get; set; }

        public List<IChannelReference> DistributionChannels { get; set; }

        public List<IChannelReference> SupplyChannels { get; set; }

        public List<IProductSelectionSetting> ProductSelections { get; set; }

        public ICustomFields Custom { get; set; }
        public StoreCreatedMessagePayload()
        {
            this.Type = "StoreCreated";
        }
    }
}
