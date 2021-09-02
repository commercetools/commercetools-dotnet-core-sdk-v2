using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Api.Models.Common
{
    public enum ReferenceTypeId
    {
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

        [Description("product-type")]
        ProductType,

        [Description("review")]
        Review,

        [Description("shipping-method")]
        ShippingMethod,

        [Description("shopping-list")]
        ShoppingList,

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
    }
    [EnumInterfaceCreator(typeof(IReferenceTypeId), "FindEnum")]
    public interface IReferenceTypeId : IJsonName
    {
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

        public static IReferenceTypeId DiscountCode = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.DiscountCode, JsonName = "discount-code" };

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

        public static IReferenceTypeId Payment = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Payment, JsonName = "payment" };

        public static IReferenceTypeId Product = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Product, JsonName = "product" };

        public static IReferenceTypeId ProductDiscount = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ProductDiscount, JsonName = "product-discount" };

        public static IReferenceTypeId ProductType = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ProductType, JsonName = "product-type" };

        public static IReferenceTypeId Review = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Review, JsonName = "review" };

        public static IReferenceTypeId ShippingMethod = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ShippingMethod, JsonName = "shipping-method" };

        public static IReferenceTypeId ShoppingList = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ShoppingList, JsonName = "shopping-list" };

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
                ProductType ,
                Review ,
                ShippingMethod ,
                ShoppingList ,
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
