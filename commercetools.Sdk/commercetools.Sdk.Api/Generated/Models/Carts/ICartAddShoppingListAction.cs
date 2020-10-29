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
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartAddShoppingListAction))]
    public interface ICartAddShoppingListAction : ICartUpdateAction
    {
        IShoppingListResourceIdentifier ShoppingList { get; set;}
        
        IChannelResourceIdentifier SupplyChannel { get; set;}
        
        IChannelResourceIdentifier DistributionChannel { get; set;}
    }
}
