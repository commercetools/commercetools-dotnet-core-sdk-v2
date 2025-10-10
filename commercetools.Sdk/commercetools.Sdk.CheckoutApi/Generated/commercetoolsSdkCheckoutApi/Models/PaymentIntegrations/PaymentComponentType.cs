using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    public enum PaymentComponentType
    {
        [Description("Component")]
        Component,

        [Description("DropIn")]
        DropIn
    }

    public class PaymentComponentTypeWrapper : IPaymentComponentType
    {
        public string JsonName { get; internal set; }
        public PaymentComponentType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IPaymentComponentType), "FindEnum")]
    public interface IPaymentComponentType : IJsonName, IEnumerable<char>
    {
        public static IPaymentComponentType Component = new PaymentComponentTypeWrapper
        { Value = PaymentComponentType.Component, JsonName = "Component" };

        public static IPaymentComponentType DropIn = new PaymentComponentTypeWrapper
        { Value = PaymentComponentType.DropIn, JsonName = "DropIn" };

        PaymentComponentType? Value { get; }

        static IPaymentComponentType[] Values()
        {
            return new[]
            {
                 Component ,
                 DropIn
             };
        }
        static IPaymentComponentType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new PaymentComponentTypeWrapper() { JsonName = value };
        }
    }
}
