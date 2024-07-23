namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitChangeParentUnitAction : IBusinessUnitChangeParentUnitAction
    {
        public string Action { get; set; }

        public IBusinessUnitResourceIdentifier ParentUnit { get; set; }
        public BusinessUnitChangeParentUnitAction()
        {
            this.Action = "changeParentUnit";
        }
    }
}
