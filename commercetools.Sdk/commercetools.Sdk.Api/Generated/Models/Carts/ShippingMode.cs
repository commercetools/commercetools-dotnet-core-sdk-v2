using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    public enum ShippingMode
    {
        [Description("Single")]
        Single,

        [Description("Multiple")]
        Multiple
    }

    public class ShippingModeWrapper : IShippingMode
    {
        public string JsonName { get; internal set; }
        public ShippingMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IShippingMode), "FindEnum")]
    public interface IShippingMode : IJsonName, IEnumerable<char>
    {
        public static IShippingMode Single = new ShippingModeWrapper
        { Value = ShippingMode.Single, JsonName = "Single" };

        public static IShippingMode Multiple = new ShippingModeWrapper
        { Value = ShippingMode.Multiple, JsonName = "Multiple" };

        ShippingMode? Value { get; }

        static IShippingMode[] Values()
        {
            return new[]
            {
                 Single ,
                 Multiple
             };
        }
        static IShippingMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ShippingModeWrapper() { JsonName = value };
        }
    }
}
