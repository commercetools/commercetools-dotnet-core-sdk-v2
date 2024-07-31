

namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitAddAssociateAction : IBusinessUnitAddAssociateAction
    {
        public string Action { get; set; }

        public IAssociateDraft Associate { get; set; }
        public BusinessUnitAddAssociateAction()
        {
            this.Action = "addAssociate";
        }
    }
}
