using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListSetLineItemCustomTypeAction : IMyShoppingListSetLineItemCustomTypeAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public MyShoppingListSetLineItemCustomTypeAction()
        {
            this.Action = "setLineItemCustomType";
        }
    }
}
