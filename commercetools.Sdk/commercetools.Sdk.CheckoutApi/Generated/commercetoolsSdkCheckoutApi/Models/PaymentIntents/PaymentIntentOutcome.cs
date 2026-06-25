using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntents
{
    public enum PaymentIntentOutcome
    {
        [Description("approved")]
        Approved,

        [Description("rejected")]
        Rejected,

        [Description("received")]
        Received
    }

    public class PaymentIntentOutcomeWrapper : IPaymentIntentOutcome
    {
        public string JsonName { get; internal set; }
        public PaymentIntentOutcome? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IPaymentIntentOutcome), "FindEnum")]
    public interface IPaymentIntentOutcome : IJsonName, IEnumerable<char>
    {
        public static IPaymentIntentOutcome Approved = new PaymentIntentOutcomeWrapper
        { Value = PaymentIntentOutcome.Approved, JsonName = "approved" };

        public static IPaymentIntentOutcome Rejected = new PaymentIntentOutcomeWrapper
        { Value = PaymentIntentOutcome.Rejected, JsonName = "rejected" };

        public static IPaymentIntentOutcome Received = new PaymentIntentOutcomeWrapper
        { Value = PaymentIntentOutcome.Received, JsonName = "received" };

        PaymentIntentOutcome? Value { get; }

        static IPaymentIntentOutcome[] Values()
        {
            return new[]
            {
                 Approved ,
                 Rejected ,
                 Received
             };
        }
        static IPaymentIntentOutcome FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new PaymentIntentOutcomeWrapper() { JsonName = value };
        }
    }
}
