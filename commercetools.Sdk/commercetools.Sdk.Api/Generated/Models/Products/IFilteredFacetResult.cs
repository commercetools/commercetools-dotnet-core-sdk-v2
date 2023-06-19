using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.FilteredFacetResult))]
    public partial interface IFilteredFacetResult : IFacetResult
    {
        long Count { get; set; }

        long? ProductCount { get; set; }

    }
}
