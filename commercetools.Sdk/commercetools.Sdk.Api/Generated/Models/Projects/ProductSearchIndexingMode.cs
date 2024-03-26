using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    public enum ProductSearchIndexingMode
    {
        [Description("ProductProjectionsSearch")]
        ProductProjectionsSearch,

        [Description("ProductsSearch")]
        ProductsSearch
    }

    public class ProductSearchIndexingModeWrapper : IProductSearchIndexingMode
    {
        public string JsonName { get; internal set; }
        public ProductSearchIndexingMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IProductSearchIndexingMode), "FindEnum")]
    public interface IProductSearchIndexingMode : IJsonName, IEnumerable<char>
    {
        public static IProductSearchIndexingMode ProductProjectionsSearch = new ProductSearchIndexingModeWrapper
        { Value = ProductSearchIndexingMode.ProductProjectionsSearch, JsonName = "ProductProjectionsSearch" };

        public static IProductSearchIndexingMode ProductsSearch = new ProductSearchIndexingModeWrapper
        { Value = ProductSearchIndexingMode.ProductsSearch, JsonName = "ProductsSearch" };

        ProductSearchIndexingMode? Value { get; }

        static IProductSearchIndexingMode[] Values()
        {
            return new[]
            {
                 ProductProjectionsSearch ,
                 ProductsSearch
             };
        }
        static IProductSearchIndexingMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductSearchIndexingModeWrapper() { JsonName = value };
        }
    }
}
