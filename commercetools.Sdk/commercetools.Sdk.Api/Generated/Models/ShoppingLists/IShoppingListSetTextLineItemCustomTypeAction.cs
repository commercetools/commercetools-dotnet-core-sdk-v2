using commercetools.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetTextLineItemCustomTypeAction))]
    public partial interface IShoppingListSetTextLineItemCustomTypeAction : IShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }
    }
}
