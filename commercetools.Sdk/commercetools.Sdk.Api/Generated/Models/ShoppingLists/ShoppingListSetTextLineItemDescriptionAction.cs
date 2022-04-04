using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ShoppingLists
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
