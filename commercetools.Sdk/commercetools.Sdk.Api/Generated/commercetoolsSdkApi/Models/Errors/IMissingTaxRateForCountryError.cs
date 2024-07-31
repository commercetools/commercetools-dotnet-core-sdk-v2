using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.MissingTaxRateForCountryError))]
    public partial interface IMissingTaxRateForCountryError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string TaxCategoryId { get; set; }

        string Country { get; set; }

        string State { get; set; }

    }
}
