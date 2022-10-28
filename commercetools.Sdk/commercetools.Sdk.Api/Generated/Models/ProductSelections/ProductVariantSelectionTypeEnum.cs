using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    public enum ProductVariantSelectionTypeEnum
    {
        [Description("inclusion")]
        Inclusion,

        [Description("exclusion")]
        Exclusion
    }

    public class ProductVariantSelectionTypeEnumWrapper : IProductVariantSelectionTypeEnum
    {
        public string JsonName { get; internal set; }
        public ProductVariantSelectionTypeEnum? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IProductVariantSelectionTypeEnum), "FindEnum")]
    public interface IProductVariantSelectionTypeEnum : IJsonName, IEnumerable<char>
    {
        public static IProductVariantSelectionTypeEnum Inclusion = new ProductVariantSelectionTypeEnumWrapper
        { Value = ProductVariantSelectionTypeEnum.Inclusion, JsonName = "inclusion" };

        public static IProductVariantSelectionTypeEnum Exclusion = new ProductVariantSelectionTypeEnumWrapper
        { Value = ProductVariantSelectionTypeEnum.Exclusion, JsonName = "exclusion" };

        ProductVariantSelectionTypeEnum? Value { get; }

        static IProductVariantSelectionTypeEnum[] Values()
        {
            return new[]
            {
                 Inclusion ,
                 Exclusion
             };
        }
        static IProductVariantSelectionTypeEnum FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductVariantSelectionTypeEnumWrapper() { JsonName = value };
        }
    }
}
