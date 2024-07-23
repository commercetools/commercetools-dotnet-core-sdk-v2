namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListSetDeleteDaysAfterLastModificationAction : IShoppingListSetDeleteDaysAfterLastModificationAction
    {
        public string Action { get; set; }

        public long? DeleteDaysAfterLastModification { get; set; }
        public ShoppingListSetDeleteDaysAfterLastModificationAction()
        {
            this.Action = "setDeleteDaysAfterLastModification";
        }
    }
}
