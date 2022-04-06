using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.ImportApi.Models.Orders
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
    }

    [EnumInterfaceCreator(typeof(IShippingMethodState), "FindEnum")]
    public interface IShippingMethodState : IJsonName
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
