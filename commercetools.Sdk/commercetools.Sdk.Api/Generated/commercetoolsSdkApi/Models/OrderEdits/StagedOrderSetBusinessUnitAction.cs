using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetBusinessUnitAction : IStagedOrderSetBusinessUnitAction
    {
        public string Action { get; set; }

        public IBusinessUnitResourceIdentifier BusinessUnit { get; set; }
        public StagedOrderSetBusinessUnitAction()
        {
            this.Action = "setBusinessUnit";
        }
    }
}
