

namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitSetUnitTypeAction : IBusinessUnitSetUnitTypeAction
    {
        public string Action { get; set; }

        public IBusinessUnitType UnitType { get; set; }

        public IBusinessUnitResourceIdentifier ParentUnit { get; set; }
        public BusinessUnitSetUnitTypeAction()
        {
            this.Action = "setUnitType";
        }
    }
}
