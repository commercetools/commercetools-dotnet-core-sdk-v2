using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.CartsConfiguration))]
    public partial interface ICartsConfiguration
    {
        long? DeleteDaysAfterLastModification { get; set; }

        bool? CountryTaxRateFallbackEnabled { get; set; }
    }
}
