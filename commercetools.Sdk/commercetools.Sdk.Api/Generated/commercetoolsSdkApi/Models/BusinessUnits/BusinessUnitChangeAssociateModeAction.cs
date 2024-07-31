

namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitChangeAssociateModeAction : IBusinessUnitChangeAssociateModeAction
    {
        public string Action { get; set; }

        public IBusinessUnitAssociateMode AssociateMode { get; set; }
        public BusinessUnitChangeAssociateModeAction()
        {
            this.Action = "changeAssociateMode";
        }
    }
}
