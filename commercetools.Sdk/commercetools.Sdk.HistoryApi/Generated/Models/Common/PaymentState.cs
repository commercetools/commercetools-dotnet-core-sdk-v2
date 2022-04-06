using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public enum PaymentState
    {
        [Description("BalanceDue")]
        BalanceDue,

        [Description("Failed")]
        Failed,

        [Description("Pending")]
        Pending,

        [Description("CreditOwed")]
        CreditOwed,

        [Description("Paid")]
        Paid
    }

    public class PaymentStateWrapper : IPaymentState
    {
        public string JsonName { get; internal set; }
        public PaymentState? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(IPaymentState), "FindEnum")]
    public interface IPaymentState : IJsonName
    {
        public static IPaymentState BalanceDue = new PaymentStateWrapper
        { Value = PaymentState.BalanceDue, JsonName = "BalanceDue" };

        public static IPaymentState Failed = new PaymentStateWrapper
        { Value = PaymentState.Failed, JsonName = "Failed" };

        public static IPaymentState Pending = new PaymentStateWrapper
        { Value = PaymentState.Pending, JsonName = "Pending" };

        public static IPaymentState CreditOwed = new PaymentStateWrapper
        { Value = PaymentState.CreditOwed, JsonName = "CreditOwed" };

        public static IPaymentState Paid = new PaymentStateWrapper
        { Value = PaymentState.Paid, JsonName = "Paid" };

        PaymentState? Value { get; }

        static IPaymentState[] Values()
        {
            return new[]
            {
                 BalanceDue ,
                 Failed ,
                 Pending ,
                 CreditOwed ,
                 Paid
             };
        }
        static IPaymentState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new PaymentStateWrapper() { JsonName = value };
        }
    }
}
