using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetLineItemDistributionChannelAction : IStagedOrderSetLineItemDistributionChannelAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public IChannelResourceIdentifier DistributionChannel { get; set;}
        public StagedOrderSetLineItemDistributionChannelAction()
        { 
           this.Action = "setLineItemDistributionChannel";
        }
    }
}
