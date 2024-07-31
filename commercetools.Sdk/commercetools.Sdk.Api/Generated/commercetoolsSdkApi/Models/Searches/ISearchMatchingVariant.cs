using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchMatchingVariant))]
    public partial interface ISearchMatchingVariant
    {
        int Id { get; set; }

        string Sku { get; set; }

    }
}
