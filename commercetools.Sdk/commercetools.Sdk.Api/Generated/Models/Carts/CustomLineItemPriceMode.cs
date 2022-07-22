using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Carts
{
    public enum CustomLineItemPriceMode
    {
        [Description("Standard")]
        Standard,

        [Description("External")]
        External
    }

    public class CustomLineItemPriceModeWrapper : ICustomLineItemPriceMode
    {
        public string JsonName { get; internal set; }
        public CustomLineItemPriceMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(ICustomLineItemPriceMode), "FindEnum")]
    public interface ICustomLineItemPriceMode : IJsonName, IEnumerable<char>
    {
        public static ICustomLineItemPriceMode Standard = new CustomLineItemPriceModeWrapper
        { Value = CustomLineItemPriceMode.Standard, JsonName = "Standard" };

        public static ICustomLineItemPriceMode External = new CustomLineItemPriceModeWrapper
        { Value = CustomLineItemPriceMode.External, JsonName = "External" };

        CustomLineItemPriceMode? Value { get; }

        static ICustomLineItemPriceMode[] Values()
        {
            return new[]
            {
                 Standard ,
                 External
             };
        }
        static ICustomLineItemPriceMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new CustomLineItemPriceModeWrapper() { JsonName = value };
        }
    }
}
