using commercetools.Api.Models.Customers;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListSetCustomerAction : IShoppingListSetCustomerAction
    {
        public string Action { get; set;}
        
        public ICustomerResourceIdentifier Customer { get; set;}
        public ShoppingListSetCustomerAction()
        { 
           this.Action = "setCustomer";
        }
    }
}
