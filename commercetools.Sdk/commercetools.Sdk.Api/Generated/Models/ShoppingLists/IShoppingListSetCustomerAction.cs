using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetCustomerAction))]
    public partial interface IShoppingListSetCustomerAction : IShoppingListUpdateAction
    {
        ICustomerResourceIdentifier Customer { get; set; }
    }
}
