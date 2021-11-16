using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetTextLineItemDescriptionAction))]
    public partial interface IShoppingListSetTextLineItemDescriptionAction : IShoppingListUpdateAction
    {
        string TextLineItemId { get; set;}
        
        ILocalizedString Description { get; set;}
    }
}
