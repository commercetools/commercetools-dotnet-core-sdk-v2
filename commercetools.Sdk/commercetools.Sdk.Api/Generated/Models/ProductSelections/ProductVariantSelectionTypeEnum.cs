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
        Exclusion,

        [Description("includeOnly")]
        IncludeOnly,

        [Description("includeAllExcept")]
        IncludeAllExcept
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

        public static IProductVariantSelectionTypeEnum IncludeOnly = new ProductVariantSelectionTypeEnumWrapper
        { Value = ProductVariantSelectionTypeEnum.IncludeOnly, JsonName = "includeOnly" };

        public static IProductVariantSelectionTypeEnum IncludeAllExcept = new ProductVariantSelectionTypeEnumWrapper
        { Value = ProductVariantSelectionTypeEnum.IncludeAllExcept, JsonName = "includeAllExcept" };

        ProductVariantSelectionTypeEnum? Value { get; }

        static IProductVariantSelectionTypeEnum[] Values()
        {
            return new[]
            {
                 Inclusion ,
                 Exclusion ,
                 IncludeOnly ,
                 IncludeAllExcept
             };
        }
        static IProductVariantSelectionTypeEnum FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductVariantSelectionTypeEnumWrapper() { JsonName = value };
        }
    }
}
