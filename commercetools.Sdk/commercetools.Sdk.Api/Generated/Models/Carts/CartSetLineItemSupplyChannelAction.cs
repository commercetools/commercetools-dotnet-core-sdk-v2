using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetLineItemSupplyChannelAction : ICartSetLineItemSupplyChannelAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }
        public CartSetLineItemSupplyChannelAction()
        {
            this.Action = "setLineItemSupplyChannel";
        }
    }
}
