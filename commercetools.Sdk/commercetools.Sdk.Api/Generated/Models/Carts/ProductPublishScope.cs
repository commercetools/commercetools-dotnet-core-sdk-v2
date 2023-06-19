using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    public enum ProductPublishScope
    {
        [Description("All")]
        All,

        [Description("Prices")]
        Prices
    }

    public class ProductPublishScopeWrapper : IProductPublishScope
    {
        public string JsonName { get; internal set; }
        public ProductPublishScope? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(IProductPublishScope), "FindEnum")]
    public interface IProductPublishScope : IJsonName, IEnumerable<char>
    {
        public static IProductPublishScope All = new ProductPublishScopeWrapper
        { Value = ProductPublishScope.All, JsonName = "All" };

        public static IProductPublishScope Prices = new ProductPublishScopeWrapper
        { Value = ProductPublishScope.Prices, JsonName = "Prices" };

        ProductPublishScope? Value { get; }

        static IProductPublishScope[] Values()
        {
            return new[]
            {
                 All ,
                 Prices
             };
        }
        static IProductPublishScope FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductPublishScopeWrapper() { JsonName = value };
        }
    }
}
