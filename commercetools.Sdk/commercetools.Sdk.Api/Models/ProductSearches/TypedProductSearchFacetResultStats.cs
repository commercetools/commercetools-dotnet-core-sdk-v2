namespace commercetools.Sdk.Api.Models.ProductSearches;

public class TypedProductSearchFacetResultStats<T> : ITypedProductSearchFacetResultStats<T>
{
    public string Name { get; set; }
    public T Min { get; set; }
    public T Max { get; set; }
    public T Mean { get; set; }
    public T Sum { get; set; }
    public long Count { get; set; }
}