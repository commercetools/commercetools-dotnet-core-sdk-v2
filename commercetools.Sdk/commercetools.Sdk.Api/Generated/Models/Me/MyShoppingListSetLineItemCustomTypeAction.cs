using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Me
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
