using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Orders
{
    public enum ReturnPaymentState
    {
        [Description("NonRefundable")]
        NonRefundable,

        [Description("Initial")]
        Initial,

        [Description("Refunded")]
        Refunded,

        [Description("NotRefunded")]
        NotRefunded
    }

    public class ReturnPaymentStateWrapper : IReturnPaymentState
    {
        public string JsonName { get; internal set; }
        public ReturnPaymentState? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(IReturnPaymentState), "FindEnum")]
    public interface IReturnPaymentState : IJsonName
    {
        public static IReturnPaymentState NonRefundable = new ReturnPaymentStateWrapper
        { Value = ReturnPaymentState.NonRefundable, JsonName = "NonRefundable" };

        public static IReturnPaymentState Initial = new ReturnPaymentStateWrapper
        { Value = ReturnPaymentState.Initial, JsonName = "Initial" };

        public static IReturnPaymentState Refunded = new ReturnPaymentStateWrapper
        { Value = ReturnPaymentState.Refunded, JsonName = "Refunded" };

        public static IReturnPaymentState NotRefunded = new ReturnPaymentStateWrapper
        { Value = ReturnPaymentState.NotRefunded, JsonName = "NotRefunded" };

        ReturnPaymentState? Value { get; }

        static IReturnPaymentState[] Values()
        {
            return new[]
            {
                 NonRefundable ,
                 Initial ,
                 Refunded ,
                 NotRefunded
             };
        }
        static IReturnPaymentState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ReturnPaymentStateWrapper() { JsonName = value };
        }
    }
}
