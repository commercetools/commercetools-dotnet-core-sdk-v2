using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    public enum ProductSearchFacetEnumScope
    {
        [Description("all")]
        All,

        [Description("query")]
        Query
    }

    public class ProductSearchFacetEnumScopeWrapper : IProductSearchFacetEnumScope
    {
        public string JsonName { get; internal set; }
        public ProductSearchFacetEnumScope? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IProductSearchFacetEnumScope), "FindEnum")]
    public interface IProductSearchFacetEnumScope : IJsonName, IEnumerable<char>
    {
        public static IProductSearchFacetEnumScope All = new ProductSearchFacetEnumScopeWrapper
        { Value = ProductSearchFacetEnumScope.All, JsonName = "all" };

        public static IProductSearchFacetEnumScope Query = new ProductSearchFacetEnumScopeWrapper
        { Value = ProductSearchFacetEnumScope.Query, JsonName = "query" };

        ProductSearchFacetEnumScope? Value { get; }

        static IProductSearchFacetEnumScope[] Values()
        {
            return new[]
            {
                 All ,
                 Query
             };
        }
        static IProductSearchFacetEnumScope FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductSearchFacetEnumScopeWrapper() { JsonName = value };
        }
    }
}
