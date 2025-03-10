using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetBusinessUnitAction : IOrderSetBusinessUnitAction
    {
        public string Action { get; set; }

        public IBusinessUnitResourceIdentifier BusinessUnit { get; set; }
        public OrderSetBusinessUnitAction()
        {
            this.Action = "setBusinessUnit";
        }
    }
}
