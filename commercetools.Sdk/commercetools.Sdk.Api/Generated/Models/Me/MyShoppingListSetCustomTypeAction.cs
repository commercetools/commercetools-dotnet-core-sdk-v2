using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Me
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
