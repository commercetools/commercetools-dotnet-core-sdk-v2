using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    public enum ProductSelectionTypeEnum
    {
        [Description("individual")]
        Individual
    }

    public class ProductSelectionTypeEnumWrapper : IProductSelectionTypeEnum
    {
        public string JsonName { get; internal set; }
        public ProductSelectionTypeEnum? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IProductSelectionTypeEnum), "FindEnum")]
    public interface IProductSelectionTypeEnum : IJsonName, IEnumerable<char>
    {
        public static IProductSelectionTypeEnum Individual = new ProductSelectionTypeEnumWrapper
        { Value = ProductSelectionTypeEnum.Individual, JsonName = "individual" };

        ProductSelectionTypeEnum? Value { get; }

        static IProductSelectionTypeEnum[] Values()
        {
            return new[]
            {
                 Individual
             };
        }
        static IProductSelectionTypeEnum FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductSelectionTypeEnumWrapper() { JsonName = value };
        }
    }
}
