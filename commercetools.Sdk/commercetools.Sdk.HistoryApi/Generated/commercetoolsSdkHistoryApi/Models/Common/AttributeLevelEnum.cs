using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public enum AttributeLevelEnum
    {
        [Description("Product")]
        Product,

        [Description("Variant")]
        Variant
    }

    public class AttributeLevelEnumWrapper : IAttributeLevelEnum
    {
        public string JsonName { get; internal set; }
        public AttributeLevelEnum? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IAttributeLevelEnum), "FindEnum")]
    public interface IAttributeLevelEnum : IJsonName, IEnumerable<char>
    {
        public static IAttributeLevelEnum Product = new AttributeLevelEnumWrapper
        { Value = AttributeLevelEnum.Product, JsonName = "Product" };

        public static IAttributeLevelEnum Variant = new AttributeLevelEnumWrapper
        { Value = AttributeLevelEnum.Variant, JsonName = "Variant" };

        AttributeLevelEnum? Value { get; }

        static IAttributeLevelEnum[] Values()
        {
            return new[]
            {
                 Product ,
                 Variant
             };
        }
        static IAttributeLevelEnum FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new AttributeLevelEnumWrapper() { JsonName = value };
        }
    }
}
