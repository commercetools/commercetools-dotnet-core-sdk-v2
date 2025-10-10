using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    public enum PaymentIntegrationType
    {
        [Description("Psp")]
        Psp,

        [Description("GiftCard")]
        GiftCard
    }

    public class PaymentIntegrationTypeWrapper : IPaymentIntegrationType
    {
        public string JsonName { get; internal set; }
        public PaymentIntegrationType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IPaymentIntegrationType), "FindEnum")]
    public interface IPaymentIntegrationType : IJsonName, IEnumerable<char>
    {
        public static IPaymentIntegrationType Psp = new PaymentIntegrationTypeWrapper
        { Value = PaymentIntegrationType.Psp, JsonName = "Psp" };

        public static IPaymentIntegrationType GiftCard = new PaymentIntegrationTypeWrapper
        { Value = PaymentIntegrationType.GiftCard, JsonName = "GiftCard" };

        PaymentIntegrationType? Value { get; }

        static IPaymentIntegrationType[] Values()
        {
            return new[]
            {
                 Psp ,
                 GiftCard
             };
        }
        static IPaymentIntegrationType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new PaymentIntegrationTypeWrapper() { JsonName = value };
        }
    }
}
