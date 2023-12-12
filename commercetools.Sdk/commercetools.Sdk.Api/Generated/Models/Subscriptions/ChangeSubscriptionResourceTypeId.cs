using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    public enum ChangeSubscriptionResourceTypeId
    {
        [Description("approval-flow")]
        ApprovalFlow,

        [Description("approval-rule")]
        ApprovalRule,

        [Description("associate-role")]
        AssociateRole,

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

        [Description("discount-code")]
        DiscountCode,

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

        [Description("product-type")]
        ProductType,

        [Description("quote")]
        Quote,

        [Description("quote-request")]
        QuoteRequest,

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

    public class ChangeSubscriptionResourceTypeIdWrapper : IChangeSubscriptionResourceTypeId
    {
        public string JsonName { get; internal set; }
        public ChangeSubscriptionResourceTypeId? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IChangeSubscriptionResourceTypeId), "FindEnum")]
    public interface IChangeSubscriptionResourceTypeId : IJsonName, IEnumerable<char>
    {
        public static IChangeSubscriptionResourceTypeId ApprovalFlow = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.ApprovalFlow, JsonName = "approval-flow" };

        public static IChangeSubscriptionResourceTypeId ApprovalRule = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.ApprovalRule, JsonName = "approval-rule" };

        public static IChangeSubscriptionResourceTypeId AssociateRole = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.AssociateRole, JsonName = "associate-role" };

        public static IChangeSubscriptionResourceTypeId BusinessUnit = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.BusinessUnit, JsonName = "business-unit" };

        public static IChangeSubscriptionResourceTypeId Cart = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.Cart, JsonName = "cart" };

        public static IChangeSubscriptionResourceTypeId CartDiscount = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.CartDiscount, JsonName = "cart-discount" };

        public static IChangeSubscriptionResourceTypeId Category = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.Category, JsonName = "category" };

        public static IChangeSubscriptionResourceTypeId Channel = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.Channel, JsonName = "channel" };

        public static IChangeSubscriptionResourceTypeId Customer = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.Customer, JsonName = "customer" };

        public static IChangeSubscriptionResourceTypeId CustomerEmailToken = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.CustomerEmailToken, JsonName = "customer-email-token" };

        public static IChangeSubscriptionResourceTypeId CustomerGroup = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.CustomerGroup, JsonName = "customer-group" };

        public static IChangeSubscriptionResourceTypeId CustomerPasswordToken = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.CustomerPasswordToken, JsonName = "customer-password-token" };

        public static IChangeSubscriptionResourceTypeId DiscountCode = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.DiscountCode, JsonName = "discount-code" };

        public static IChangeSubscriptionResourceTypeId Extension = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.Extension, JsonName = "extension" };

        public static IChangeSubscriptionResourceTypeId InventoryEntry = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.InventoryEntry, JsonName = "inventory-entry" };

        public static IChangeSubscriptionResourceTypeId KeyValueDocument = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.KeyValueDocument, JsonName = "key-value-document" };

        public static IChangeSubscriptionResourceTypeId Order = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.Order, JsonName = "order" };

        public static IChangeSubscriptionResourceTypeId OrderEdit = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.OrderEdit, JsonName = "order-edit" };

        public static IChangeSubscriptionResourceTypeId Payment = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.Payment, JsonName = "payment" };

        public static IChangeSubscriptionResourceTypeId Product = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.Product, JsonName = "product" };

        public static IChangeSubscriptionResourceTypeId ProductDiscount = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.ProductDiscount, JsonName = "product-discount" };

        public static IChangeSubscriptionResourceTypeId ProductPrice = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.ProductPrice, JsonName = "product-price" };

        public static IChangeSubscriptionResourceTypeId ProductSelection = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.ProductSelection, JsonName = "product-selection" };

        public static IChangeSubscriptionResourceTypeId ProductType = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.ProductType, JsonName = "product-type" };

        public static IChangeSubscriptionResourceTypeId Quote = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.Quote, JsonName = "quote" };

        public static IChangeSubscriptionResourceTypeId QuoteRequest = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.QuoteRequest, JsonName = "quote-request" };

        public static IChangeSubscriptionResourceTypeId Review = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.Review, JsonName = "review" };

        public static IChangeSubscriptionResourceTypeId ShippingMethod = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.ShippingMethod, JsonName = "shipping-method" };

        public static IChangeSubscriptionResourceTypeId ShoppingList = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.ShoppingList, JsonName = "shopping-list" };

        public static IChangeSubscriptionResourceTypeId StagedQuote = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.StagedQuote, JsonName = "staged-quote" };

        public static IChangeSubscriptionResourceTypeId StandalonePrice = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.StandalonePrice, JsonName = "standalone-price" };

        public static IChangeSubscriptionResourceTypeId State = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.State, JsonName = "state" };

        public static IChangeSubscriptionResourceTypeId Store = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.Store, JsonName = "store" };

        public static IChangeSubscriptionResourceTypeId Subscription = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.Subscription, JsonName = "subscription" };

        public static IChangeSubscriptionResourceTypeId TaxCategory = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.TaxCategory, JsonName = "tax-category" };

        public static IChangeSubscriptionResourceTypeId Type = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.Type, JsonName = "type" };

        public static IChangeSubscriptionResourceTypeId Zone = new ChangeSubscriptionResourceTypeIdWrapper
        { Value = ChangeSubscriptionResourceTypeId.Zone, JsonName = "zone" };

        ChangeSubscriptionResourceTypeId? Value { get; }

        static IChangeSubscriptionResourceTypeId[] Values()
        {
            return new[]
            {
                 ApprovalFlow ,
                 ApprovalRule ,
                 AssociateRole ,
                 BusinessUnit ,
                 Cart ,
                 CartDiscount ,
                 Category ,
                 Channel ,
                 Customer ,
                 CustomerEmailToken ,
                 CustomerGroup ,
                 CustomerPasswordToken ,
                 DiscountCode ,
                 Extension ,
                 InventoryEntry ,
                 KeyValueDocument ,
                 Order ,
                 OrderEdit ,
                 Payment ,
                 Product ,
                 ProductDiscount ,
                 ProductPrice ,
                 ProductSelection ,
                 ProductType ,
                 Quote ,
                 QuoteRequest ,
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
        static IChangeSubscriptionResourceTypeId FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ChangeSubscriptionResourceTypeIdWrapper() { JsonName = value };
        }
    }
}
