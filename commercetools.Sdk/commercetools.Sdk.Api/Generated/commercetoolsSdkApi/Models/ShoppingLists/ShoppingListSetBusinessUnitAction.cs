using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListSetBusinessUnitAction : IShoppingListSetBusinessUnitAction
    {
        public string Action { get; set; }

        public IBusinessUnitResourceIdentifier BusinessUnit { get; set; }
        public ShoppingListSetBusinessUnitAction()
        {
            this.Action = "setBusinessUnit";
        }
    }
}
