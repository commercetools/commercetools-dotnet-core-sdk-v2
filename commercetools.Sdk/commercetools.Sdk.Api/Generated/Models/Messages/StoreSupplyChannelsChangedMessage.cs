using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreSupplyChannelsChangedMessage : IStoreSupplyChannelsChangedMessage
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public long SequenceNumber { get; set; }

        public IReference Resource { get; set; }

        public long ResourceVersion { get; set; }

        public string Type { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

        public IList<IChannelReference> AddedSupplyChannels { get; set; }
        public IEnumerable<IChannelReference> AddedSupplyChannelsEnumerable { set => AddedSupplyChannels = value.ToList(); }


        public IList<IChannelReference> RemovedSupplyChannels { get; set; }
        public IEnumerable<IChannelReference> RemovedSupplyChannelsEnumerable { set => RemovedSupplyChannels = value.ToList(); }

        public StoreSupplyChannelsChangedMessage()
        {
            this.Type = "StoreSupplyChannelsChanged";
        }
    }
}
