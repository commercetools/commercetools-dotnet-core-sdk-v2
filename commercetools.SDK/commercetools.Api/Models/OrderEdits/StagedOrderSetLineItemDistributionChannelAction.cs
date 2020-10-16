using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setLineItemDistributionChannel")]
    public partial class StagedOrderSetLineItemDistributionChannelAction : StagedOrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ChannelResourceIdentifier DistributionChannel { get; set;}
        public StagedOrderSetLineItemDistributionChannelAction()
        { 
           this.Action = "setLineItemDistributionChannel";
        }
    }
}
