using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListChangeNameAction : IMyShoppingListChangeNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public MyShoppingListChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
