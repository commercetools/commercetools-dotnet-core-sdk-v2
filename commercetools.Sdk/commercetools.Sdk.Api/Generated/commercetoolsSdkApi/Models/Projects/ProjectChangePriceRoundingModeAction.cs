using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangePriceRoundingModeAction : IProjectChangePriceRoundingModeAction
    {
        public string Action { get; set; }

        public IRoundingMode PriceRoundingMode { get; set; }
        public ProjectChangePriceRoundingModeAction()
        {
            this.Action = "changePriceRoundingMode";
        }
    }
}
