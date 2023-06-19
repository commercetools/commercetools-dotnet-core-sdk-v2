using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    public enum ProductPriceModeEnum
    {
        [Description("Embedded")]
        Embedded,

        [Description("Standalone")]
        Standalone
    }

    public class ProductPriceModeEnumWrapper : IProductPriceModeEnum
    {
        public string JsonName { get; internal set; }
        public ProductPriceModeEnum? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IProductPriceModeEnum), "FindEnum")]
    public interface IProductPriceModeEnum : IJsonName, IEnumerable<char>
    {
        public static IProductPriceModeEnum Embedded = new ProductPriceModeEnumWrapper
        { Value = ProductPriceModeEnum.Embedded, JsonName = "Embedded" };

        public static IProductPriceModeEnum Standalone = new ProductPriceModeEnumWrapper
        { Value = ProductPriceModeEnum.Standalone, JsonName = "Standalone" };

        ProductPriceModeEnum? Value { get; }

        static IProductPriceModeEnum[] Values()
        {
            return new[]
            {
                 Embedded ,
                 Standalone
             };
        }
        static IProductPriceModeEnum FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductPriceModeEnumWrapper() { JsonName = value };
        }
    }
}
