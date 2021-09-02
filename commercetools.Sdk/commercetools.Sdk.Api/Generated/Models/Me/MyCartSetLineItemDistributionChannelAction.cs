using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartSetLineItemDistributionChannelAction : IMyCartSetLineItemDistributionChannelAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }
        public MyCartSetLineItemDistributionChannelAction()
        {
            this.Action = "setLineItemDistributionChannel";
        }
    }
}
