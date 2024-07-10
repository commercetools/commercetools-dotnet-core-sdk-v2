using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetBusinessUnitAction : ICartSetBusinessUnitAction
    {
        public string Action { get; set; }

        public IBusinessUnitResourceIdentifier BusinessUnit { get; set; }
        public CartSetBusinessUnitAction()
        {
            this.Action = "setBusinessUnit";
        }
    }
}
