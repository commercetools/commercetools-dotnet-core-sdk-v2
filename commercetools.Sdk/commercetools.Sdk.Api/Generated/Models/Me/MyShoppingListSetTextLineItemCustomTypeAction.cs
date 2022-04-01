using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Me
{
    public partial class MyShoppingListSetTextLineItemCustomTypeAction : IMyShoppingListSetTextLineItemCustomTypeAction
    {
        public string Action { get; set; }

        public string TextLineItemId { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public MyShoppingListSetTextLineItemCustomTypeAction()
        {
            this.Action = "setTextLineItemCustomType";
        }
    }
}
