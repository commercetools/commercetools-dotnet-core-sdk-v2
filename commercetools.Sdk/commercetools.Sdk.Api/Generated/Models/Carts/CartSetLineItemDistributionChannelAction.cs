using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public  partial class CartSetLineItemDistributionChannelAction : ICartSetLineItemDistributionChannelAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public IChannelResourceIdentifier DistributionChannel { get; set;}
        public CartSetLineItemDistributionChannelAction()
        { 
           this.Action = "setLineItemDistributionChannel";
        }
    }
}
