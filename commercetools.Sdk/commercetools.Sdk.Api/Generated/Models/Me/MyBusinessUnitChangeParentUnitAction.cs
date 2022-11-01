using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.Me
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
