using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    public enum ProductSearchStatus
    {
        [Description("Activated")]
        Activated,

        [Description("Deactivated")]
        Deactivated
    }

    public class ProductSearchStatusWrapper : IProductSearchStatus
    {
        public string JsonName { get; internal set; }
        public ProductSearchStatus? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IProductSearchStatus), "FindEnum")]
    public interface IProductSearchStatus : IJsonName, IEnumerable<char>
    {
        public static IProductSearchStatus Activated = new ProductSearchStatusWrapper
        { Value = ProductSearchStatus.Activated, JsonName = "Activated" };

        public static IProductSearchStatus Deactivated = new ProductSearchStatusWrapper
        { Value = ProductSearchStatus.Deactivated, JsonName = "Deactivated" };

        ProductSearchStatus? Value { get; }

        static IProductSearchStatus[] Values()
        {
            return new[]
            {
                 Activated ,
                 Deactivated
             };
        }
        static IProductSearchStatus FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductSearchStatusWrapper() { JsonName = value };
        }
    }
}
