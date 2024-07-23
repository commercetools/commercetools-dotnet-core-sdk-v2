namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitChangeNameAction : IBusinessUnitChangeNameAction
    {
        public string Action { get; set; }

        public string Name { get; set; }
        public BusinessUnitChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
