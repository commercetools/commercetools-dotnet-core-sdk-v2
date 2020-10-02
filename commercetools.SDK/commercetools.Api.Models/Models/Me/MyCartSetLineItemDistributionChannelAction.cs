using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setLineItemDistributionChannel")]
    public partial class MyCartSetLineItemDistributionChannelAction : MyCartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ChannelResourceIdentifier DistributionChannel { get; set;}
        public MyCartSetLineItemDistributionChannelAction()
        { 
           this.Action = "setLineItemDistributionChannel";
        }
    }
}
