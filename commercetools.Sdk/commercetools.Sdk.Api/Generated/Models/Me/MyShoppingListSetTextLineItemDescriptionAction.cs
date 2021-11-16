using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Me
{
    public partial class MyShoppingListSetTextLineItemDescriptionAction : IMyShoppingListSetTextLineItemDescriptionAction
    {
        public string Action { get; set;}
        
        public string TextLineItemId { get; set;}
        
        public ILocalizedString Description { get; set;}
        public MyShoppingListSetTextLineItemDescriptionAction()
        { 
           this.Action = "setTextLineItemDescription";
        }
    }
}
