using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.PaymentMethods
{
    public enum PaymentMethodStatus
    {
        [Description("Active")]
        Active,

        [Description("Inactive")]
        Inactive
    }

    public class PaymentMethodStatusWrapper : IPaymentMethodStatus
    {
        public string JsonName { get; internal set; }
        public PaymentMethodStatus? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IPaymentMethodStatus), "FindEnum")]
    public interface IPaymentMethodStatus : IJsonName, IEnumerable<char>
    {
        public static IPaymentMethodStatus Active = new PaymentMethodStatusWrapper
        { Value = PaymentMethodStatus.Active, JsonName = "Active" };

        public static IPaymentMethodStatus Inactive = new PaymentMethodStatusWrapper
        { Value = PaymentMethodStatus.Inactive, JsonName = "Inactive" };

        PaymentMethodStatus? Value { get; }

        static IPaymentMethodStatus[] Values()
        {
            return new[]
            {
                 Active ,
                 Inactive
             };
        }
        static IPaymentMethodStatus FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new PaymentMethodStatusWrapper() { JsonName = value };
        }
    }
}
