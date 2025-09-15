using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Common
{
    public enum ReferenceTypeId
    {
        [Description("cart")]
        Cart,

        [Description("order")]
        Order,

        [Description("payment")]
        Payment,

        [Description("application")]
        Application,

        [Description("payment-integration")]
        PaymentIntegration
    }

    public class ReferenceTypeIdWrapper : IReferenceTypeId
    {
        public string JsonName { get; internal set; }
        public ReferenceTypeId? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IReferenceTypeId), "FindEnum")]
    public interface IReferenceTypeId : IJsonName, IEnumerable<char>
    {
        public static IReferenceTypeId Cart = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Cart, JsonName = "cart" };

        public static IReferenceTypeId Order = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Order, JsonName = "order" };

        public static IReferenceTypeId Payment = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Payment, JsonName = "payment" };

        public static IReferenceTypeId Application = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Application, JsonName = "application" };

        public static IReferenceTypeId PaymentIntegration = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.PaymentIntegration, JsonName = "payment-integration" };

        ReferenceTypeId? Value { get; }

        static IReferenceTypeId[] Values()
        {
            return new[]
            {
                 Cart ,
                 Order ,
                 Payment ,
                 Application ,
                 PaymentIntegration
             };
        }
        static IReferenceTypeId FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ReferenceTypeIdWrapper() { JsonName = value };
        }
    }
}
