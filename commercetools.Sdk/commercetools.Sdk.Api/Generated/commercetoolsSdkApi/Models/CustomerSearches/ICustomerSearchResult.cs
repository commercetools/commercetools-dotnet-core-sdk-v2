using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomerSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerSearches.CustomerSearchResult))]
    public partial interface ICustomerSearchResult
    {
        string Id { get; set; }

        decimal Relevance { get; set; }

    }
}
