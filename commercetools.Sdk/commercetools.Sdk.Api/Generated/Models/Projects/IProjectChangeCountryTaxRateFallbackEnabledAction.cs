using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeCountryTaxRateFallbackEnabledAction))]
    public partial interface IProjectChangeCountryTaxRateFallbackEnabledAction : IProjectUpdateAction
    {
        bool CountryTaxRateFallbackEnabled { get; set; }
    }
}
