using commercetools.Api.Generated.Models.Channels;
using commercetools.Api.Generated.Models.Orders;
using commercetools.Api.Generated.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.OrderEdits
{
    public interface IStagedOrderAddShoppingListAction : IStagedOrderUpdateAction
    {
        IShoppingListResourceIdentifier ShoppingList { get; set;}
        
        IChannelResourceIdentifier SupplyChannel { get; set;}
        
        IChannelResourceIdentifier DistributionChannel { get; set;}
    }
}
