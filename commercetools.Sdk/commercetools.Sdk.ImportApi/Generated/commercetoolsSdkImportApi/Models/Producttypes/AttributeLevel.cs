using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Producttypes
{
    public enum AttributeLevel
    {
        [Description("Variant")]
        Variant,

        [Description("Product")]
        Product
    }

    public class AttributeLevelWrapper : IAttributeLevel
    {
        public string JsonName { get; internal set; }
        public AttributeLevel? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IAttributeLevel), "FindEnum")]
    public interface IAttributeLevel : IJsonName, IEnumerable<char>
    {
        public static IAttributeLevel Variant = new AttributeLevelWrapper
        { Value = AttributeLevel.Variant, JsonName = "Variant" };

        public static IAttributeLevel Product = new AttributeLevelWrapper
        { Value = AttributeLevel.Product, JsonName = "Product" };

        AttributeLevel? Value { get; }

        static IAttributeLevel[] Values()
        {
            return new[]
            {
                 Variant ,
                 Product
             };
        }
        static IAttributeLevel FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new AttributeLevelWrapper() { JsonName = value };
        }
    }
}
