using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartAddShoppingListAction : ICartAddShoppingListAction
    {
        public string Action { get; set; }

        public IShoppingListResourceIdentifier ShoppingList { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }
        public CartAddShoppingListAction()
        {
            this.Action = "addShoppingList";
        }
    }
}
