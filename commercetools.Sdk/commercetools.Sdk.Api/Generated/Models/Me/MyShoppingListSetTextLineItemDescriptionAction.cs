using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Me
{
    public partial class MyShoppingListSetTextLineItemDescriptionAction : IMyShoppingListSetTextLineItemDescriptionAction
    {
        public string Action { get; set; }

        public string TextLineItemId { get; set; }

        public ILocalizedString Description { get; set; }
        public MyShoppingListSetTextLineItemDescriptionAction()
        {
            this.Action = "setTextLineItemDescription";
        }
    }
}
