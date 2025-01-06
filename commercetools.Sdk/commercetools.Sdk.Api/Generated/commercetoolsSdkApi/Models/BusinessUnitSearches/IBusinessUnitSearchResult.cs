using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnitSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnitSearches.BusinessUnitSearchResult))]
    public partial interface IBusinessUnitSearchResult
    {
        string Id { get; set; }

        decimal Relevance { get; set; }

    }
}
