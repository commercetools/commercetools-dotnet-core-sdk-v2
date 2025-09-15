using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntents
{
    public enum PaymentIntentOperation
    {
        [Description("capturePayment")]
        CapturePayment,

        [Description("refundPayment")]
        RefundPayment,

        [Description("cancelPayment")]
        CancelPayment,

        [Description("reversePayment")]
        ReversePayment
    }

    public class PaymentIntentOperationWrapper : IPaymentIntentOperation
    {
        public string JsonName { get; internal set; }
        public PaymentIntentOperation? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IPaymentIntentOperation), "FindEnum")]
    public interface IPaymentIntentOperation : IJsonName, IEnumerable<char>
    {
        public static IPaymentIntentOperation CapturePayment = new PaymentIntentOperationWrapper
        { Value = PaymentIntentOperation.CapturePayment, JsonName = "capturePayment" };

        public static IPaymentIntentOperation RefundPayment = new PaymentIntentOperationWrapper
        { Value = PaymentIntentOperation.RefundPayment, JsonName = "refundPayment" };

        public static IPaymentIntentOperation CancelPayment = new PaymentIntentOperationWrapper
        { Value = PaymentIntentOperation.CancelPayment, JsonName = "cancelPayment" };

        public static IPaymentIntentOperation ReversePayment = new PaymentIntentOperationWrapper
        { Value = PaymentIntentOperation.ReversePayment, JsonName = "reversePayment" };

        PaymentIntentOperation? Value { get; }

        static IPaymentIntentOperation[] Values()
        {
            return new[]
            {
                 CapturePayment ,
                 RefundPayment ,
                 CancelPayment ,
                 ReversePayment
             };
        }
        static IPaymentIntentOperation FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new PaymentIntentOperationWrapper() { JsonName = value };
        }
    }
}
