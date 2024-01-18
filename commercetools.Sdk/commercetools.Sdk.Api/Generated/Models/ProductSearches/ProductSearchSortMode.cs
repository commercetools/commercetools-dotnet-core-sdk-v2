using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    public enum ProductSearchSortMode
    {
        [Description("min")]
        Min,

        [Description("max")]
        Max,

        [Description("avg")]
        Avg,

        [Description("sum")]
        Sum
    }

    public class ProductSearchSortModeWrapper : IProductSearchSortMode
    {
        public string JsonName { get; internal set; }
        public ProductSearchSortMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IProductSearchSortMode), "FindEnum")]
    public interface IProductSearchSortMode : IJsonName, IEnumerable<char>
    {
        public static IProductSearchSortMode Min = new ProductSearchSortModeWrapper
        { Value = ProductSearchSortMode.Min, JsonName = "min" };

        public static IProductSearchSortMode Max = new ProductSearchSortModeWrapper
        { Value = ProductSearchSortMode.Max, JsonName = "max" };

        public static IProductSearchSortMode Avg = new ProductSearchSortModeWrapper
        { Value = ProductSearchSortMode.Avg, JsonName = "avg" };

        public static IProductSearchSortMode Sum = new ProductSearchSortModeWrapper
        { Value = ProductSearchSortMode.Sum, JsonName = "sum" };

        ProductSearchSortMode? Value { get; }

        static IProductSearchSortMode[] Values()
        {
            return new[]
            {
                 Min ,
                 Max ,
                 Avg ,
                 Sum
             };
        }
        static IProductSearchSortMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductSearchSortModeWrapper() { JsonName = value };
        }
    }
}
