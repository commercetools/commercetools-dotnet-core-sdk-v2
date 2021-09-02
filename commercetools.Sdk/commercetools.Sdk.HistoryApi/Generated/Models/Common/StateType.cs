using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.HistoryApi.Models.Common
{
    public enum StateType
    {
        [Description("OrderState")]
        OrderState,

        [Description("LineItemState")]
        LineItemState,

        [Description("ProductState")]
        ProductState,

        [Description("ReviewState")]
        ReviewState,

        [Description("PaymentState")]
        PaymentState
    }

    public class StateTypeWrapper : IStateType
    {
        public string JsonName { get; internal set; }
        public StateType? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(IStateType), "FindEnum")]
    public interface IStateType : IJsonName
    {
        public static IStateType OrderState = new StateTypeWrapper
        { Value = StateType.OrderState, JsonName = "OrderState" };

        public static IStateType LineItemState = new StateTypeWrapper
        { Value = StateType.LineItemState, JsonName = "LineItemState" };

        public static IStateType ProductState = new StateTypeWrapper
        { Value = StateType.ProductState, JsonName = "ProductState" };

        public static IStateType ReviewState = new StateTypeWrapper
        { Value = StateType.ReviewState, JsonName = "ReviewState" };

        public static IStateType PaymentState = new StateTypeWrapper
        { Value = StateType.PaymentState, JsonName = "PaymentState" };

        StateType? Value { get; }

        static IStateType[] Values()
        {
            return new[]
            {
                 OrderState ,
                 LineItemState ,
                 ProductState ,
                 ReviewState ,
                 PaymentState
             };
        }
        static IStateType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new StateTypeWrapper() { JsonName = value };
        }
    }
}
