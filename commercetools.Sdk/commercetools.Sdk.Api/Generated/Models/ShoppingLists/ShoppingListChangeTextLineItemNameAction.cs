using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListChangeTextLineItemNameAction : IShoppingListChangeTextLineItemNameAction
    {
        public string Action { get; set;}
        
        public string TextLineItemId { get; set;}
        
        public ILocalizedString Name { get; set;}
        public ShoppingListChangeTextLineItemNameAction()
        { 
           this.Action = "changeTextLineItemName";
        }
    }
}
