using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Me
{
    public partial class MyShoppingListSetCustomTypeAction : IMyShoppingListSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public MyShoppingListSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
