using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeCountryTaxRateFallbackEnabledAction))]
    public partial interface IProjectChangeCountryTaxRateFallbackEnabledAction : IProjectUpdateAction
    {
        bool CountryTaxRateFallbackEnabled { get; set; }

    }
}
