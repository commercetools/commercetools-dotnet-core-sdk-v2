using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListSetTextLineItemDescriptionAction : IShoppingListSetTextLineItemDescriptionAction
    {
        public string Action { get; set; }

        public string TextLineItemId { get; set; }

        public ILocalizedString Description { get; set; }
        public ShoppingListSetTextLineItemDescriptionAction()
        {
            this.Action = "setTextLineItemDescription";
        }
    }
}
