using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Carts
{
    public enum ShippingMode
    {
        [Description("Single")]
        Single,

        [Description("Multi")]
        Multi
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

        public static IShippingMode Multi = new ShippingModeWrapper
        { Value = ShippingMode.Multi, JsonName = "Multi" };

        ShippingMode? Value { get; }

        static IShippingMode[] Values()
        {
            return new[]
            {
                 Single ,
                 Multi
             };
        }
        static IShippingMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ShippingModeWrapper() { JsonName = value };
        }
    }
}