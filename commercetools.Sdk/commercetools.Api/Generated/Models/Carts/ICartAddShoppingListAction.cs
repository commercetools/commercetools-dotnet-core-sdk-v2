using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Channels;
using commercetools.Api.Generated.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Carts
{
    public interface ICartAddShoppingListAction : ICartUpdateAction
    {
        IShoppingListResourceIdentifier ShoppingList { get; set;}
        
        IChannelResourceIdentifier SupplyChannel { get; set;}
        
        IChannelResourceIdentifier DistributionChannel { get; set;}
    }
}
