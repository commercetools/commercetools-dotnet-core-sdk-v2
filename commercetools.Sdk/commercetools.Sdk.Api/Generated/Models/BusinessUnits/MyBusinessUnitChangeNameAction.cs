namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class MyBusinessUnitChangeNameAction : IMyBusinessUnitChangeNameAction
    {
        public string Action { get; set; }

        public string Name { get; set; }
        public MyBusinessUnitChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
