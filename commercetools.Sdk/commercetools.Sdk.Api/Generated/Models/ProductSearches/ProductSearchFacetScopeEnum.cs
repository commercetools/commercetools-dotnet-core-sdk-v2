using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    public enum ProductSearchFacetScopeEnum
    {
        [Description("all")]
        All,

        [Description("query")]
        Query
    }

    public class ProductSearchFacetScopeEnumWrapper : IProductSearchFacetScopeEnum
    {
        public string JsonName { get; internal set; }
        public ProductSearchFacetScopeEnum? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IProductSearchFacetScopeEnum), "FindEnum")]
    public interface IProductSearchFacetScopeEnum : IJsonName, IEnumerable<char>
    {
        public static IProductSearchFacetScopeEnum All = new ProductSearchFacetScopeEnumWrapper
        { Value = ProductSearchFacetScopeEnum.All, JsonName = "all" };

        public static IProductSearchFacetScopeEnum Query = new ProductSearchFacetScopeEnumWrapper
        { Value = ProductSearchFacetScopeEnum.Query, JsonName = "query" };

        ProductSearchFacetScopeEnum? Value { get; }

        static IProductSearchFacetScopeEnum[] Values()
        {
            return new[]
            {
                 All ,
                 Query
             };
        }
        static IProductSearchFacetScopeEnum FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductSearchFacetScopeEnumWrapper() { JsonName = value };
        }
    }
}
