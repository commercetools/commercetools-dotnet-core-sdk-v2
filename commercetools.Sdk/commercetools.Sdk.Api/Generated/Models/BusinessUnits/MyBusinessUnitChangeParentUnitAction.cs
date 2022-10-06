namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class MyBusinessUnitChangeParentUnitAction : IMyBusinessUnitChangeParentUnitAction
    {
        public string Action { get; set; }

        public IBusinessUnitResourceIdentifier ParentUnit { get; set; }
        public MyBusinessUnitChangeParentUnitAction()
        {
            this.Action = "changeParentUnit";
        }
    }
}
