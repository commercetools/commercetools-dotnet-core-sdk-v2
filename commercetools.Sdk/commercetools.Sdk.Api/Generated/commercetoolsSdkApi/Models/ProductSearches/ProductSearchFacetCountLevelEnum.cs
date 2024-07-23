using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    public enum ProductSearchFacetCountLevelEnum
    {
        [Description("products")]
        Products,

        [Description("variants")]
        Variants
    }

    public class ProductSearchFacetCountLevelEnumWrapper : IProductSearchFacetCountLevelEnum
    {
        public string JsonName { get; internal set; }
        public ProductSearchFacetCountLevelEnum? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IProductSearchFacetCountLevelEnum), "FindEnum")]
    public interface IProductSearchFacetCountLevelEnum : IJsonName, IEnumerable<char>
    {
        public static IProductSearchFacetCountLevelEnum Products = new ProductSearchFacetCountLevelEnumWrapper
        { Value = ProductSearchFacetCountLevelEnum.Products, JsonName = "products" };

        public static IProductSearchFacetCountLevelEnum Variants = new ProductSearchFacetCountLevelEnumWrapper
        { Value = ProductSearchFacetCountLevelEnum.Variants, JsonName = "variants" };

        ProductSearchFacetCountLevelEnum? Value { get; }

        static IProductSearchFacetCountLevelEnum[] Values()
        {
            return new[]
            {
                 Products ,
                 Variants
             };
        }
        static IProductSearchFacetCountLevelEnum FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductSearchFacetCountLevelEnumWrapper() { JsonName = value };
        }
    }
}
