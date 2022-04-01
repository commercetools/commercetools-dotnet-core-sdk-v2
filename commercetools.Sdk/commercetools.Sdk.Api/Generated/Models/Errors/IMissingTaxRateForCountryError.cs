using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.MissingTaxRateForCountryError))]
    public partial interface IMissingTaxRateForCountryError : IErrorObject
    {
        string TaxCategoryId { get; set; }

        string Country { get; set; }

        string State { get; set; }
    }
}
