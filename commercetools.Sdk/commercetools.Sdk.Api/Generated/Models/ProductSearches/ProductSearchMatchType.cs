using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    public enum ProductSearchMatchType
    {
        [Description("any")]
        Any,

        [Description("all")]
        All
    }

    public class ProductSearchMatchTypeWrapper : IProductSearchMatchType
    {
        public string JsonName { get; internal set; }
        public ProductSearchMatchType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IProductSearchMatchType), "FindEnum")]
    public interface IProductSearchMatchType : IJsonName, IEnumerable<char>
    {
        public static IProductSearchMatchType Any = new ProductSearchMatchTypeWrapper
        { Value = ProductSearchMatchType.Any, JsonName = "any" };

        public static IProductSearchMatchType All = new ProductSearchMatchTypeWrapper
        { Value = ProductSearchMatchType.All, JsonName = "all" };

        ProductSearchMatchType? Value { get; }

        static IProductSearchMatchType[] Values()
        {
            return new[]
            {
                 Any ,
                 All
             };
        }
        static IProductSearchMatchType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductSearchMatchTypeWrapper() { JsonName = value };
        }
    }
}
