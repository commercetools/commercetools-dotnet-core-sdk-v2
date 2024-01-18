using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchSorting))]
    public partial interface IProductSearchSorting
    {
        string Field { get; set; }

        string Language { get; set; }

        IProductSearchSortOrder Order { get; set; }

        IProductSearchSortMode Mode { get; set; }

        IProductSearchAttributeType AttributeType { get; set; }

        IProductSearchQueryExpression Filter { get; set; }

        bool? Internal { get; set; }

    }
}
