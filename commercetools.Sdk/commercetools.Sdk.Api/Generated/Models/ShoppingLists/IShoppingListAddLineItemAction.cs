using commercetools.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListAddLineItemAction))]
    public partial interface IShoppingListAddLineItemAction : IShoppingListUpdateAction
    {
        string Sku { get; set;}
        
        string ProductId { get; set;}
        
        long? VariantId { get; set;}
        
        long? Quantity { get; set;}
        
        DateTime? AddedAt { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
    }
}
