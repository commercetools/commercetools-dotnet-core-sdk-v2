using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("addShoppingList")]
    public class StagedOrderAddShoppingListAction : StagedOrderUpdateAction
    {
        public ShoppingListResourceIdentifier ShoppingList { get; set;}
        
        public ChannelResourceIdentifier SupplyChannel { get; set;}
        
        public ChannelResourceIdentifier DistributionChannel { get; set;}
    }
}
