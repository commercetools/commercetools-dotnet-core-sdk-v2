using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.MLApi.Models.Common
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

        [Description("customer-group")]
        CustomerGroup,

        [Description("discount-code")]
        DiscountCode,

        [Description("key-value-document")]
        KeyValueDocument,

        [Description("payment")]
        Payment,

        [Description("product")]
        Product,

        [Description("product-type")]
        ProductType,

        [Description("product-discount")]
        ProductDiscount,

        [Description("order")]
        Order,

        [Description("review")]
        Review,

        [Description("shopping-list")]
        ShoppingList,

        [Description("shipping-method")]
        ShippingMethod,

        [Description("state")]
        State,

        [Description("store")]
        Store,

        [Description("tax-category")]
        TaxCategory,

        [Description("type")]
        Type,

        [Description("zone")]
        Zone,

        [Description("inventory-entry")]
        InventoryEntry,

        [Description("order-edit")]
        OrderEdit
    }

    public class ReferenceTypeIdWrapper : IReferenceTypeId
    {
        public string JsonName { get; internal set; }
        public ReferenceTypeId? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
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

        public static IReferenceTypeId CustomerGroup = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.CustomerGroup, JsonName = "customer-group" };

        public static IReferenceTypeId DiscountCode = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.DiscountCode, JsonName = "discount-code" };

        public static IReferenceTypeId KeyValueDocument = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.KeyValueDocument, JsonName = "key-value-document" };

        public static IReferenceTypeId Payment = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Payment, JsonName = "payment" };

        public static IReferenceTypeId Product = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Product, JsonName = "product" };

        public static IReferenceTypeId ProductType = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ProductType, JsonName = "product-type" };

        public static IReferenceTypeId ProductDiscount = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ProductDiscount, JsonName = "product-discount" };

        public static IReferenceTypeId Order = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Order, JsonName = "order" };

        public static IReferenceTypeId Review = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Review, JsonName = "review" };

        public static IReferenceTypeId ShoppingList = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ShoppingList, JsonName = "shopping-list" };

        public static IReferenceTypeId ShippingMethod = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.ShippingMethod, JsonName = "shipping-method" };

        public static IReferenceTypeId State = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.State, JsonName = "state" };

        public static IReferenceTypeId Store = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Store, JsonName = "store" };

        public static IReferenceTypeId TaxCategory = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.TaxCategory, JsonName = "tax-category" };

        public static IReferenceTypeId Type = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Type, JsonName = "type" };

        public static IReferenceTypeId Zone = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.Zone, JsonName = "zone" };

        public static IReferenceTypeId InventoryEntry = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.InventoryEntry, JsonName = "inventory-entry" };

        public static IReferenceTypeId OrderEdit = new ReferenceTypeIdWrapper
        { Value = ReferenceTypeId.OrderEdit, JsonName = "order-edit" };

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
                 CustomerGroup ,
                 DiscountCode ,
                 KeyValueDocument ,
                 Payment ,
                 Product ,
                 ProductType ,
                 ProductDiscount ,
                 Order ,
                 Review ,
                 ShoppingList ,
                 ShippingMethod ,
                 State ,
                 Store ,
                 TaxCategory ,
                 Type ,
                 Zone ,
                 InventoryEntry ,
                 OrderEdit
             };
        }
        static IReferenceTypeId FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ReferenceTypeIdWrapper() { JsonName = value };
        }
    }
}
