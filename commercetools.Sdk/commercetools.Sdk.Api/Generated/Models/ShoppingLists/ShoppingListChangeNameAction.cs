using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListChangeNameAction : IShoppingListChangeNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public ShoppingListChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
