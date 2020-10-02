using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setLineItemDistributionChannel")]
    public partial class CartSetLineItemDistributionChannelAction : CartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ChannelResourceIdentifier DistributionChannel { get; set;}
        public CartSetLineItemDistributionChannelAction()
        { 
           this.Action = "setLineItemDistributionChannel";
        }
    }
}
