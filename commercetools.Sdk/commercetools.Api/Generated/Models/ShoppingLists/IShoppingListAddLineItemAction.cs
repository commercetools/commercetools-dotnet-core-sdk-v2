using commercetools.Api.Generated.Models.ShoppingLists;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ShoppingLists
{
    public interface IShoppingListAddLineItemAction : IShoppingListUpdateAction
    {
        string Sku { get; set;}
        
        string ProductId { get; set;}
        
        long VariantId { get; set;}
        
        long Quantity { get; set;}
        
        DateTime AddedAt { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
    }
}
