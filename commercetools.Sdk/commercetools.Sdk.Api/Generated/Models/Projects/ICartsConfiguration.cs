using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.CartsConfiguration))]
    public partial interface ICartsConfiguration
    {
        long? DeleteDaysAfterLastModification { get; set; }

        bool? CountryTaxRateFallbackEnabled { get; set; }
    }
}
