using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.ProjectChangeCountryTaxRateFallbackEnabledAction))]
    public partial interface IProjectChangeCountryTaxRateFallbackEnabledAction : IProjectUpdateAction
    {
        bool CountryTaxRateFallbackEnabled { get; set; }
    }
}
