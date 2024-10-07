using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    public enum ProductSearchFacetScope
    {
        [Description("all")]
        All,

        [Description("query")]
        Query
    }

    public class ProductSearchFacetScopeWrapper : IProductSearchFacetScope
    {
        public string JsonName { get; internal set; }
        public ProductSearchFacetScope? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IProductSearchFacetScope), "FindEnum")]
    public interface IProductSearchFacetScope : IJsonName, IEnumerable<char>
    {
        public static IProductSearchFacetScope All = new ProductSearchFacetScopeWrapper
        { Value = ProductSearchFacetScope.All, JsonName = "all" };

        public static IProductSearchFacetScope Query = new ProductSearchFacetScopeWrapper
        { Value = ProductSearchFacetScope.Query, JsonName = "query" };

        ProductSearchFacetScope? Value { get; }

        static IProductSearchFacetScope[] Values()
        {
            return new[]
            {
                 All ,
                 Query
             };
        }
        static IProductSearchFacetScope FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductSearchFacetScopeWrapper() { JsonName = value };
        }
    }
}
