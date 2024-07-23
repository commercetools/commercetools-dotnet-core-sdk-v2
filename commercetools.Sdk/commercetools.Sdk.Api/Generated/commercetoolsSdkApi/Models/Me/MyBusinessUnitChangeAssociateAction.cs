using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitChangeAssociateAction : IMyBusinessUnitChangeAssociateAction
    {
        public string Action { get; set; }

        public IAssociateDraft Associate { get; set; }
        public MyBusinessUnitChangeAssociateAction()
        {
            this.Action = "changeAssociate";
        }
    }
}
