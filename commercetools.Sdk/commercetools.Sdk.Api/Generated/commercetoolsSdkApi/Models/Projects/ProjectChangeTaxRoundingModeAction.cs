using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeTaxRoundingModeAction : IProjectChangeTaxRoundingModeAction
    {
        public string Action { get; set; }

        public IRoundingMode TaxRoundingMode { get; set; }
        public ProjectChangeTaxRoundingModeAction()
        {
            this.Action = "changeTaxRoundingMode";
        }
    }
}
