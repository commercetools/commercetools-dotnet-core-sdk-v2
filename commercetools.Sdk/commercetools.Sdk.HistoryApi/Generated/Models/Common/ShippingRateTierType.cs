using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public enum ShippingRateTierType
    {
        [Description("CartValue")]
        CartValue,

        [Description("CartClassification")]
        CartClassification,

        [Description("CartScore")]
        CartScore
    }

    public class ShippingRateTierTypeWrapper : IShippingRateTierType
    {
        public string JsonName { get; internal set; }
        public ShippingRateTierType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IShippingRateTierType), "FindEnum")]
    public interface IShippingRateTierType : IJsonName, IEnumerable<char>
    {
        public static IShippingRateTierType CartValue = new ShippingRateTierTypeWrapper
        { Value = ShippingRateTierType.CartValue, JsonName = "CartValue" };

        public static IShippingRateTierType CartClassification = new ShippingRateTierTypeWrapper
        { Value = ShippingRateTierType.CartClassification, JsonName = "CartClassification" };

        public static IShippingRateTierType CartScore = new ShippingRateTierTypeWrapper
        { Value = ShippingRateTierType.CartScore, JsonName = "CartScore" };

        ShippingRateTierType? Value { get; }

        static IShippingRateTierType[] Values()
        {
            return new[]
            {
                 CartValue ,
                 CartClassification ,
                 CartScore
             };
        }
        static IShippingRateTierType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ShippingRateTierTypeWrapper() { JsonName = value };
        }
    }
}
