using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    public enum ExtensionResourceTypeId
    {
        [Description("cart")]
        Cart,

        [Description("order")]
        Order,

        [Description("payment")]
        Payment,

        [Description("customer")]
        Customer,

        [Description("quote-request")]
        QuoteRequest,

        [Description("staged-quote")]
        StagedQuote,

        [Description("quote")]
        Quote,

        [Description("business-unit")]
        BusinessUnit
    }

    public class ExtensionResourceTypeIdWrapper : IExtensionResourceTypeId
    {
        public string JsonName { get; internal set; }
        public ExtensionResourceTypeId? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IExtensionResourceTypeId), "FindEnum")]
    public interface IExtensionResourceTypeId : IJsonName, IEnumerable<char>
    {
        public static IExtensionResourceTypeId Cart = new ExtensionResourceTypeIdWrapper
        { Value = ExtensionResourceTypeId.Cart, JsonName = "cart" };

        public static IExtensionResourceTypeId Order = new ExtensionResourceTypeIdWrapper
        { Value = ExtensionResourceTypeId.Order, JsonName = "order" };

        public static IExtensionResourceTypeId Payment = new ExtensionResourceTypeIdWrapper
        { Value = ExtensionResourceTypeId.Payment, JsonName = "payment" };

        public static IExtensionResourceTypeId Customer = new ExtensionResourceTypeIdWrapper
        { Value = ExtensionResourceTypeId.Customer, JsonName = "customer" };

        public static IExtensionResourceTypeId QuoteRequest = new ExtensionResourceTypeIdWrapper
        { Value = ExtensionResourceTypeId.QuoteRequest, JsonName = "quote-request" };

        public static IExtensionResourceTypeId StagedQuote = new ExtensionResourceTypeIdWrapper
        { Value = ExtensionResourceTypeId.StagedQuote, JsonName = "staged-quote" };

        public static IExtensionResourceTypeId Quote = new ExtensionResourceTypeIdWrapper
        { Value = ExtensionResourceTypeId.Quote, JsonName = "quote" };

        public static IExtensionResourceTypeId BusinessUnit = new ExtensionResourceTypeIdWrapper
        { Value = ExtensionResourceTypeId.BusinessUnit, JsonName = "business-unit" };

        ExtensionResourceTypeId? Value { get; }

        static IExtensionResourceTypeId[] Values()
        {
            return new[]
            {
                 Cart ,
                 Order ,
                 Payment ,
                 Customer ,
                 QuoteRequest ,
                 StagedQuote ,
                 Quote ,
                 BusinessUnit
             };
        }
        static IExtensionResourceTypeId FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ExtensionResourceTypeIdWrapper() { JsonName = value };
        }
    }
}
