using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    public enum ReferenceTypeId
    {
        [Description("approval-flow")]
        ApprovalFlow,

        [Description("approval-rule")]
        ApprovalRule,

        [Description("associate-role")]
        AssociateRole,

        [Description("attribute-group")]
        AttributeGroup,

        [Description("business-unit")]
        BusinessUnit,

        [Description("cart")]
        Cart,

        [Description("cart-discount")]
        CartDiscount,

        [Description("category")]
        Category,

        [Description("channel")]
        Channel,

        [Description("customer")]
        Customer,

        [Description("customer-email-token")]
        CustomerEmailToken,

        [Description("customer-group")]
        CustomerGroup,

        [Description("customer-password-token")]
        CustomerPasswordToken,

        [Description("direct-discount")]
        DirectDiscount,

        [Description("discount-code")]
        DiscountCode,

        [Description("discount-group")]
        DiscountGroup,

        [Description("extension")]
        Extension,

        [Description("inventory-entry")]
        InventoryEntry,

        [Description("key-value-document")]
        KeyValueDocument,

        [Description("order")]
        Order,

        [Description("order-edit")]
        OrderEdit,

        [Description("payment-method")]
        PaymentMethod,

        [Description("payment")]
        Payment,

        [Description("product")]
        Product,

        [Description("product-discount")]
        ProductDiscount,

        [Description("product-price")]
        ProductPrice,

        [Description("product-selection")]
        ProductSelection,

        [Description("product-tailoring")]
        ProductTailoring,

        [Description("product-type")]
        ProductType,

        [Description("quote")]
        Quote,

        [Description("quote-request")]
        QuoteRequest,

        [Description("recurrence-policy")]
        RecurrencePolicy,

        [Description("recurring-order")]
        RecurringOrder,

        [Description("review")]
        Review,

        [Description("shipping-method")]
        ShippingMethod,

        [Description("shopping-list")]
        ShoppingList,

        [Description("staged-quote")]
        StagedQuote,

        [Description("standalone-price")]
        StandalonePrice,

        [Description("state")]
        State,

        [Description("store")]
        Store,

        [Description("subscription")]
        Subscription,

        [Description("tax-category")]
        TaxCategory,

        [Description("type")]
        Type,

        [Description("zone")]
        Zone
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
        public static IReferenceTypeId ApprovalFlow = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ApprovalFlow, JsonName = "approval-flow" };

        public static IReferenceTypeId ApprovalRule = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ApprovalRule, JsonName = "approval-rule" };

        public static IReferenceTypeId AssociateRole = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.AssociateRole, JsonName = "associate-role" };

        public static IReferenceTypeId AttributeGroup = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.AttributeGroup, JsonName = "attribute-group" };

        public static IReferenceTypeId BusinessUnit = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.BusinessUnit, JsonName = "business-unit" };

        public static IReferenceTypeId Cart = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Cart, JsonName = "cart" };

        public static IReferenceTypeId CartDiscount = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.CartDiscount, JsonName = "cart-discount" };

        public static IReferenceTypeId Category = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Category, JsonName = "category" };

        public static IReferenceTypeId Channel = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Channel, JsonName = "channel" };

        public static IReferenceTypeId Customer = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Customer, JsonName = "customer" };

        public static IReferenceTypeId CustomerEmailToken = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.CustomerEmailToken, JsonName = "customer-email-token" };

        public static IReferenceTypeId CustomerGroup = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.CustomerGroup, JsonName = "customer-group" };

        public static IReferenceTypeId CustomerPasswordToken = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.CustomerPasswordToken, JsonName = "customer-password-token" };

        public static IReferenceTypeId DirectDiscount = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.DirectDiscount, JsonName = "direct-discount" };

        public static IReferenceTypeId DiscountCode = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.DiscountCode, JsonName = "discount-code" };

        public static IReferenceTypeId DiscountGroup = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.DiscountGroup, JsonName = "discount-group" };

        public static IReferenceTypeId Extension = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Extension, JsonName = "extension" };

        public static IReferenceTypeId InventoryEntry = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.InventoryEntry, JsonName = "inventory-entry" };

        public static IReferenceTypeId KeyValueDocument = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.KeyValueDocument, JsonName = "key-value-document" };

        public static IReferenceTypeId Order = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Order, JsonName = "order" };

        public static IReferenceTypeId OrderEdit = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.OrderEdit, JsonName = "order-edit" };

        public static IReferenceTypeId PaymentMethod = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.PaymentMethod, JsonName = "payment-method" };

        public static IReferenceTypeId Payment = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Payment, JsonName = "payment" };

        public static IReferenceTypeId Product = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Product, JsonName = "product" };

        public static IReferenceTypeId ProductDiscount = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ProductDiscount, JsonName = "product-discount" };

        public static IReferenceTypeId ProductPrice = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ProductPrice, JsonName = "product-price" };

        public static IReferenceTypeId ProductSelection = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ProductSelection, JsonName = "product-selection" };

        public static IReferenceTypeId ProductTailoring = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ProductTailoring, JsonName = "product-tailoring" };

        public static IReferenceTypeId ProductType = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ProductType, JsonName = "product-type" };

        public static IReferenceTypeId Quote = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Quote, JsonName = "quote" };

        public static IReferenceTypeId QuoteRequest = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.QuoteRequest, JsonName = "quote-request" };

        public static IReferenceTypeId RecurrencePolicy = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.RecurrencePolicy, JsonName = "recurrence-policy" };

        public static IReferenceTypeId RecurringOrder = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.RecurringOrder, JsonName = "recurring-order" };

        public static IReferenceTypeId Review = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Review, JsonName = "review" };

        public static IReferenceTypeId ShippingMethod = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ShippingMethod, JsonName = "shipping-method" };

        public static IReferenceTypeId ShoppingList = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ShoppingList, JsonName = "shopping-list" };

        public static IReferenceTypeId StagedQuote = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.StagedQuote, JsonName = "staged-quote" };

        public static IReferenceTypeId StandalonePrice = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.StandalonePrice, JsonName = "standalone-price" };

        public static IReferenceTypeId State = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.State, JsonName = "state" };

        public static IReferenceTypeId Store = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Store, JsonName = "store" };

        public static IReferenceTypeId Subscription = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Subscription, JsonName = "subscription" };

        public static IReferenceTypeId TaxCategory = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.TaxCategory, JsonName = "tax-category" };

        public static IReferenceTypeId Type = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Type, JsonName = "type" };

        public static IReferenceTypeId Zone = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Zone, JsonName = "zone" };

        ReferenceTypeId? Value { get; }

        static IReferenceTypeId[] Values()
        {
            return new[]
            {
                 ApprovalFlow ,
                 ApprovalRule ,
                 AssociateRole ,
                 AttributeGroup ,
                 BusinessUnit ,
                 Cart ,
                 CartDiscount ,
                 Category ,
                 Channel ,
                 Customer ,
                 CustomerEmailToken ,
                 CustomerGroup ,
                 CustomerPasswordToken ,
                 DirectDiscount ,
                 DiscountCode ,
                 DiscountGroup ,
                 Extension ,
                 InventoryEntry ,
                 KeyValueDocument ,
                 Order ,
                 OrderEdit ,
                 PaymentMethod ,
                 Payment ,
                 Product ,
                 ProductDiscount ,
                 ProductPrice ,
                 ProductSelection ,
                 ProductTailoring ,
                 ProductType ,
                 Quote ,
                 QuoteRequest ,
                 RecurrencePolicy ,
                 RecurringOrder ,
                 Review ,
                 ShippingMethod ,
                 ShoppingList ,
                 StagedQuote ,
                 StandalonePrice ,
                 State ,
                 Store ,
                 Subscription ,
                 TaxCategory ,
                 Type ,
                 Zone
             };
        }
        static IReferenceTypeId FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ReferenceTypeIdWrapper() { JsonName = value };
        }
    }
}
