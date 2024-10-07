using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLMissingTaxRateForCountryError))]
    public partial interface IGraphQLMissingTaxRateForCountryError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        string TaxCategoryId { get; set; }

        string Country { get; set; }

        string State { get; set; }

    }
}
