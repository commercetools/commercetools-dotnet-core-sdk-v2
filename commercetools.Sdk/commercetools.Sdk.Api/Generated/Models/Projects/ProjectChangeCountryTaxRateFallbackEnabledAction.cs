namespace commercetools.Api.Models.Projects
{
    public partial class ProjectChangeCountryTaxRateFallbackEnabledAction : IProjectChangeCountryTaxRateFallbackEnabledAction
    {
        public string Action { get; set; }

        public bool CountryTaxRateFallbackEnabled { get; set; }
        public ProjectChangeCountryTaxRateFallbackEnabledAction()
        {
            this.Action = "changeCountryTaxRateFallbackEnabled";
        }
    }
}
