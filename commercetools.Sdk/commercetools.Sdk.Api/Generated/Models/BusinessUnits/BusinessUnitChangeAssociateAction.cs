namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitChangeAssociateAction : IBusinessUnitChangeAssociateAction
    {
        public string Action { get; set; }

        public IAssociateDraft Associate { get; set; }
        public BusinessUnitChangeAssociateAction()
        {
            this.Action = "changeAssociate";
        }
    }
}
