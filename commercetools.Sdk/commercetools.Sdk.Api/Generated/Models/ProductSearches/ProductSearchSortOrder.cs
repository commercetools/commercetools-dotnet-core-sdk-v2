using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    public enum ProductSearchSortOrder
    {
        [Description("asc")]
        Asc,

        [Description("desc")]
        Desc
    }

    public class ProductSearchSortOrderWrapper : IProductSearchSortOrder
    {
        public string JsonName { get; internal set; }
        public ProductSearchSortOrder? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IProductSearchSortOrder), "FindEnum")]
    public interface IProductSearchSortOrder : IJsonName, IEnumerable<char>
    {
        public static IProductSearchSortOrder Asc = new ProductSearchSortOrderWrapper
        { Value = ProductSearchSortOrder.Asc, JsonName = "asc" };

        public static IProductSearchSortOrder Desc = new ProductSearchSortOrderWrapper
        { Value = ProductSearchSortOrder.Desc, JsonName = "desc" };

        ProductSearchSortOrder? Value { get; }

        static IProductSearchSortOrder[] Values()
        {
            return new[]
            {
                 Asc ,
                 Desc
             };
        }
        static IProductSearchSortOrder FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductSearchSortOrderWrapper() { JsonName = value };
        }
    }
}
