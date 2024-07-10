using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderAddShoppingListAction : IStagedOrderAddShoppingListAction
    {
        public string Action { get; set; }

        public IShoppingListResourceIdentifier ShoppingList { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }
        public StagedOrderAddShoppingListAction()
        {
            this.Action = "addShoppingList";
        }
    }
}
