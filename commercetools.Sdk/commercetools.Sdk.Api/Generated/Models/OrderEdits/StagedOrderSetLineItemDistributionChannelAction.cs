using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetLineItemDistributionChannelAction : IStagedOrderSetLineItemDistributionChannelAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }
        public StagedOrderSetLineItemDistributionChannelAction()
        {
            this.Action = "setLineItemDistributionChannel";
        }
    }
}
