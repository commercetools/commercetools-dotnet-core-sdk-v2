using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    public enum ProductSearchFacetDistinctBucketSortBy
    {
        [Description("count")]
        Count,

        [Description("key")]
        Key
    }

    public class ProductSearchFacetDistinctBucketSortByWrapper : IProductSearchFacetDistinctBucketSortBy
    {
        public string JsonName { get; internal set; }
        public ProductSearchFacetDistinctBucketSortBy? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public new IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(IProductSearchFacetDistinctBucketSortBy), "FindEnum")]
    public interface IProductSearchFacetDistinctBucketSortBy : IJsonName, IEnumerable<char>
    {
        public static IProductSearchFacetDistinctBucketSortBy Count = new ProductSearchFacetDistinctBucketSortByWrapper
        { Value = ProductSearchFacetDistinctBucketSortBy.Count, JsonName = "count" };

        public static IProductSearchFacetDistinctBucketSortBy Key = new ProductSearchFacetDistinctBucketSortByWrapper
        { Value = ProductSearchFacetDistinctBucketSortBy.Key, JsonName = "key" };

        ProductSearchFacetDistinctBucketSortBy? Value { get; }

        static IProductSearchFacetDistinctBucketSortBy[] Values()
        {
            return new[]
            {
                 Count ,
                 Key
             };
        }
        static IProductSearchFacetDistinctBucketSortBy FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductSearchFacetDistinctBucketSortByWrapper() { JsonName = value };
        }
    }
}
