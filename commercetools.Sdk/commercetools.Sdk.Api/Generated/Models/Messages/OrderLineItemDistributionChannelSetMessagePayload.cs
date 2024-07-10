using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderLineItemDistributionChannelSetMessagePayload : IOrderLineItemDistributionChannelSetMessagePayload
    {
        public string Type { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public IChannelReference DistributionChannel { get; set; }
        public OrderLineItemDistributionChannelSetMessagePayload()
        {
            this.Type = "OrderLineItemDistributionChannelSet";
        }
    }
}
