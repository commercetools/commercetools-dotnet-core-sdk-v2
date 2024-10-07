using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    public enum MessageSubscriptionResourceTypeId
    {
        [Description("approval-flow")]
        ApprovalFlow,

        [Description("approval-rule")]
        ApprovalRule,

        [Description("associate-role")]
        AssociateRole,

        [Description("business-unit")]
        BusinessUnit,

        [Description("category")]
        Category,

        [Description("customer")]
        Customer,

        [Description("customer-email-token")]
        CustomerEmailToken,

        [Description("customer-group")]
        CustomerGroup,

        [Description("customer-password-token")]
        CustomerPasswordToken,

        [Description("inventory-entry")]
        InventoryEntry,

        [Description("order")]
        Order,

        [Description("payment")]
        Payment,

        [Description("product")]
        Product,

        [Description("product-selection")]
        ProductSelection,

        [Description("product-tailoring")]
        ProductTailoring,

        [Description("quote")]
        Quote,

        [Description("quote-request")]
        QuoteRequest,

        [Description("review")]
        Review,

        [Description("staged-quote")]
        StagedQuote,

        [Description("standalone-price")]
        StandalonePrice,

        [Description("store")]
        Store
    }

    public class MessageSubscriptionResourceTypeIdWrapper : IMessageSubscriptionResourceTypeId
    {
        public string JsonName { get; internal set; }
        public MessageSubscriptionResourceTypeId? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IMessageSubscriptionResourceTypeId), "FindEnum")]
    public interface IMessageSubscriptionResourceTypeId : IJsonName, IEnumerable<char>
    {
        public static IMessageSubscriptionResourceTypeId ApprovalFlow = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.ApprovalFlow, JsonName = "approval-flow" };

        public static IMessageSubscriptionResourceTypeId ApprovalRule = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.ApprovalRule, JsonName = "approval-rule" };

        public static IMessageSubscriptionResourceTypeId AssociateRole = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.AssociateRole, JsonName = "associate-role" };

        public static IMessageSubscriptionResourceTypeId BusinessUnit = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.BusinessUnit, JsonName = "business-unit" };

        public static IMessageSubscriptionResourceTypeId Category = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.Category, JsonName = "category" };

        public static IMessageSubscriptionResourceTypeId Customer = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.Customer, JsonName = "customer" };

        public static IMessageSubscriptionResourceTypeId CustomerEmailToken = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.CustomerEmailToken, JsonName = "customer-email-token" };

        public static IMessageSubscriptionResourceTypeId CustomerGroup = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.CustomerGroup, JsonName = "customer-group" };

        public static IMessageSubscriptionResourceTypeId CustomerPasswordToken = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.CustomerPasswordToken, JsonName = "customer-password-token" };

        public static IMessageSubscriptionResourceTypeId InventoryEntry = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.InventoryEntry, JsonName = "inventory-entry" };

        public static IMessageSubscriptionResourceTypeId Order = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.Order, JsonName = "order" };

        public static IMessageSubscriptionResourceTypeId Payment = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.Payment, JsonName = "payment" };

        public static IMessageSubscriptionResourceTypeId Product = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.Product, JsonName = "product" };

        public static IMessageSubscriptionResourceTypeId ProductSelection = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.ProductSelection, JsonName = "product-selection" };

        public static IMessageSubscriptionResourceTypeId ProductTailoring = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.ProductTailoring, JsonName = "product-tailoring" };

        public static IMessageSubscriptionResourceTypeId Quote = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.Quote, JsonName = "quote" };

        public static IMessageSubscriptionResourceTypeId QuoteRequest = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.QuoteRequest, JsonName = "quote-request" };

        public static IMessageSubscriptionResourceTypeId Review = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.Review, JsonName = "review" };

        public static IMessageSubscriptionResourceTypeId StagedQuote = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.StagedQuote, JsonName = "staged-quote" };

        public static IMessageSubscriptionResourceTypeId StandalonePrice = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.StandalonePrice, JsonName = "standalone-price" };

        public static IMessageSubscriptionResourceTypeId Store = new MessageSubscriptionResourceTypeIdWrapper
        { Value = MessageSubscriptionResourceTypeId.Store, JsonName = "store" };

        MessageSubscriptionResourceTypeId? Value { get; }

        static IMessageSubscriptionResourceTypeId[] Values()
        {
            return new[]
            {
                 ApprovalFlow ,
                 ApprovalRule ,
                 AssociateRole ,
                 BusinessUnit ,
                 Category ,
                 Customer ,
                 CustomerEmailToken ,
                 CustomerGroup ,
                 CustomerPasswordToken ,
                 InventoryEntry ,
                 Order ,
                 Payment ,
                 Product ,
                 ProductSelection ,
                 ProductTailoring ,
                 Quote ,
                 QuoteRequest ,
                 Review ,
                 StagedQuote ,
                 StandalonePrice ,
                 Store
             };
        }
        static IMessageSubscriptionResourceTypeId FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new MessageSubscriptionResourceTypeIdWrapper() { JsonName = value };
        }
    }
}
