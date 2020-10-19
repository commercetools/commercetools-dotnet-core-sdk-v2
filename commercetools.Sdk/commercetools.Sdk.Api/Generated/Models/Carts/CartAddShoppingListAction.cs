using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("addShoppingList")]
    public partial class CartAddShoppingListAction : CartUpdateAction
    {
        public ShoppingListResourceIdentifier ShoppingList { get; set;}
        
        public ChannelResourceIdentifier SupplyChannel { get; set;}
        
        public ChannelResourceIdentifier DistributionChannel { get; set;}
        public CartAddShoppingListAction()
        { 
           this.Action = "addShoppingList";
        }
    }
}
