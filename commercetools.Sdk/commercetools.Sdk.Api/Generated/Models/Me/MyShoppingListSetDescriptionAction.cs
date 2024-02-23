using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListSetDescriptionAction : IMyShoppingListSetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public MyShoppingListSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
