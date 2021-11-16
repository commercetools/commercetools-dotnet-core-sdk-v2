using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Me
{
    public partial class MyShoppingListChangeTextLineItemNameAction : IMyShoppingListChangeTextLineItemNameAction
    {
        public string Action { get; set;}
        
        public string TextLineItemId { get; set;}
        
        public ILocalizedString Name { get; set;}
        public MyShoppingListChangeTextLineItemNameAction()
        { 
           this.Action = "changeTextLineItemName";
        }
    }
}
