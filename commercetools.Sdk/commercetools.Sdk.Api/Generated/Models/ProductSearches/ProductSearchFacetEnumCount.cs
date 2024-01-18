using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    public enum ProductSearchFacetEnumCount
    {
        [Description("products")]
        Products,

        [Description("variants")]
        Variants
    }

    public class ProductSearchFacetEnumCountWrapper : IProductSearchFacetEnumCount
    {
        public string JsonName { get; internal set; }
        public ProductSearchFacetEnumCount? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IProductSearchFacetEnumCount), "FindEnum")]
    public interface IProductSearchFacetEnumCount : IJsonName, IEnumerable<char>
    {
        public static IProductSearchFacetEnumCount Products = new ProductSearchFacetEnumCountWrapper
        { Value = ProductSearchFacetEnumCount.Products, JsonName = "products" };

        public static IProductSearchFacetEnumCount Variants = new ProductSearchFacetEnumCountWrapper
        { Value = ProductSearchFacetEnumCount.Variants, JsonName = "variants" };

        ProductSearchFacetEnumCount? Value { get; }

        static IProductSearchFacetEnumCount[] Values()
        {
            return new[]
            {
                 Products ,
                 Variants
             };
        }
        static IProductSearchFacetEnumCount FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductSearchFacetEnumCountWrapper() { JsonName = value };
        }
    }
}
