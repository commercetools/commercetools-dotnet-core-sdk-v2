namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListSetKeyAction : IShoppingListSetKeyAction
    {
        public string Action { get; set;}
        
        public string Key { get; set;}
        public ShoppingListSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
