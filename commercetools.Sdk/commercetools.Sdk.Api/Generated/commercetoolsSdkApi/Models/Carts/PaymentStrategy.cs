using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    public enum PaymentStrategy
    {
        [Description("Checkout")]
        Checkout
    }

    public class PaymentStrategyWrapper : IPaymentStrategy
    {
        public string JsonName { get; internal set; }
        public PaymentStrategy? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IPaymentStrategy), "FindEnum")]
    public interface IPaymentStrategy : IJsonName, IEnumerable<char>
    {
        public static IPaymentStrategy Checkout = new PaymentStrategyWrapper
        { Value = PaymentStrategy.Checkout, JsonName = "Checkout" };

        PaymentStrategy? Value { get; }

        static IPaymentStrategy[] Values()
        {
            return new[]
            {
                 Checkout
             };
        }
        static IPaymentStrategy FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new PaymentStrategyWrapper() { JsonName = value };
        }
    }
}
