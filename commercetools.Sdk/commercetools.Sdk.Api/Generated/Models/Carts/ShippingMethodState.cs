using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Carts
{
    public enum ShippingMethodState
    {
        [Description("DoesNotMatchCart")]
        DoesNotMatchCart,

        [Description("MatchesCart")]
        MatchesCart
    }

    public class ShippingMethodStateWrapper : IShippingMethodState
    {
        public string JsonName { get; internal set; }
        public ShippingMethodState? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IShippingMethodState), "FindEnum")]
    public interface IShippingMethodState : IJsonName, IEnumerable<char>
    {
        public static IShippingMethodState DoesNotMatchCart = new ShippingMethodStateWrapper
        { Value = ShippingMethodState.DoesNotMatchCart, JsonName = "DoesNotMatchCart" };

        public static IShippingMethodState MatchesCart = new ShippingMethodStateWrapper
        { Value = ShippingMethodState.MatchesCart, JsonName = "MatchesCart" };

        ShippingMethodState? Value { get; }

        static IShippingMethodState[] Values()
        {
            return new[]
            {
                 DoesNotMatchCart ,
                 MatchesCart
             };
        }
        static IShippingMethodState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ShippingMethodStateWrapper() { JsonName = value };
        }
    }
}
