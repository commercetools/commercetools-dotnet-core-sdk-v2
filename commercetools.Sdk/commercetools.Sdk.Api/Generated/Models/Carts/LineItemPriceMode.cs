using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Carts
{
    public enum LineItemPriceMode
    {
        [Description("Platform")]
        Platform,

        [Description("ExternalPrice")]
        ExternalPrice,

        [Description("ExternalTotal")]
        ExternalTotal
    }

    public class LineItemPriceModeWrapper : ILineItemPriceMode
    {
        public string JsonName { get; internal set; }
        public LineItemPriceMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(ILineItemPriceMode), "FindEnum")]
    public interface ILineItemPriceMode : IJsonName, IEnumerable<char>
    {
        public static ILineItemPriceMode Platform = new LineItemPriceModeWrapper
        { Value = LineItemPriceMode.Platform, JsonName = "Platform" };

        public static ILineItemPriceMode ExternalPrice = new LineItemPriceModeWrapper
        { Value = LineItemPriceMode.ExternalPrice, JsonName = "ExternalPrice" };

        public static ILineItemPriceMode ExternalTotal = new LineItemPriceModeWrapper
        { Value = LineItemPriceMode.ExternalTotal, JsonName = "ExternalTotal" };

        LineItemPriceMode? Value { get; }

        static ILineItemPriceMode[] Values()
        {
            return new[]
            {
                 Platform ,
                 ExternalPrice ,
                 ExternalTotal
             };
        }
        static ILineItemPriceMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new LineItemPriceModeWrapper() { JsonName = value };
        }
    }
}
