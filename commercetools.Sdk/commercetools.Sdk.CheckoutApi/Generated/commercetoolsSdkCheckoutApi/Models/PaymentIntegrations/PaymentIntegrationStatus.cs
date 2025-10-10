using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    public enum PaymentIntegrationStatus
    {
        [Description("Active")]
        Active,

        [Description("Inactive")]
        Inactive
    }

    public class PaymentIntegrationStatusWrapper : IPaymentIntegrationStatus
    {
        public string JsonName { get; internal set; }
        public PaymentIntegrationStatus? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IPaymentIntegrationStatus), "FindEnum")]
    public interface IPaymentIntegrationStatus : IJsonName, IEnumerable<char>
    {
        public static IPaymentIntegrationStatus Active = new PaymentIntegrationStatusWrapper
        { Value = PaymentIntegrationStatus.Active, JsonName = "Active" };

        public static IPaymentIntegrationStatus Inactive = new PaymentIntegrationStatusWrapper
        { Value = PaymentIntegrationStatus.Inactive, JsonName = "Inactive" };

        PaymentIntegrationStatus? Value { get; }

        static IPaymentIntegrationStatus[] Values()
        {
            return new[]
            {
                 Active ,
                 Inactive
             };
        }
        static IPaymentIntegrationStatus FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new PaymentIntegrationStatusWrapper() { JsonName = value };
        }
    }
}
