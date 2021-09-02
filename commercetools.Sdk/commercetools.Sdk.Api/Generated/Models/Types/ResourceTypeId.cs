using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Api.Models.Types
{
    public enum ResourceTypeId
    {
        [Description("address")]
        Address,

        [Description("asset")]
        Asset,

        [Description("category")]
        Category,

        [Description("channel")]
        Channel,

        [Description("customer")]
        Customer,

        [Description("order")]
        Order,

        [Description("order-edit")]
        OrderEdit,

        [Description("inventory-entry")]
        InventoryEntry,

        [Description("line-item")]
        LineItem,

        [Description("custom-line-item")]
        CustomLineItem,

        [Description("product-price")]
        ProductPrice,

        [Description("payment")]
        Payment,

        [Description("payment-interface-interaction")]
        PaymentInterfaceInteraction,

        [Description("review")]
        Review,

        [Description("shipping-method")]
        ShippingMethod,

        [Description("shopping-list")]
        ShoppingList,

        [Description("shopping-list-text-line-item")]
        ShoppingListTextLineItem,

        [Description("discount-code")]
        DiscountCode,

        [Description("cart-discount")]
        CartDiscount,

        [Description("customer-group")]
        CustomerGroup,

        [Description("store")]
        Store
    }

    public class ResourceTypeIdWrapper : IResourceTypeId
    {
        public string JsonName { get; internal set; }
        public ResourceTypeId? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(IResourceTypeId), "FindEnum")]
    public interface IResourceTypeId : IJsonName
    {
        public static IResourceTypeId Address = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Address, JsonName = "address" };

        public static IResourceTypeId Asset = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Asset, JsonName = "asset" };

        public static IResourceTypeId Category = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Category, JsonName = "category" };

        public static IResourceTypeId Channel = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Channel, JsonName = "channel" };

        public static IResourceTypeId Customer = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Customer, JsonName = "customer" };

        public static IResourceTypeId Order = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Order, JsonName = "order" };

        public static IResourceTypeId OrderEdit = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.OrderEdit, JsonName = "order-edit" };

        public static IResourceTypeId InventoryEntry = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.InventoryEntry, JsonName = "inventory-entry" };

        public static IResourceTypeId LineItem = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.LineItem, JsonName = "line-item" };

        public static IResourceTypeId CustomLineItem = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.CustomLineItem, JsonName = "custom-line-item" };

        public static IResourceTypeId ProductPrice = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.ProductPrice, JsonName = "product-price" };

        public static IResourceTypeId Payment = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Payment, JsonName = "payment" };

        public static IResourceTypeId PaymentInterfaceInteraction = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.PaymentInterfaceInteraction, JsonName = "payment-interface-interaction" };

        public static IResourceTypeId Review = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Review, JsonName = "review" };

        public static IResourceTypeId ShippingMethod = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.ShippingMethod, JsonName = "shipping-method" };

        public static IResourceTypeId ShoppingList = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.ShoppingList, JsonName = "shopping-list" };

        public static IResourceTypeId ShoppingListTextLineItem = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.ShoppingListTextLineItem, JsonName = "shopping-list-text-line-item" };

        public static IResourceTypeId DiscountCode = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.DiscountCode, JsonName = "discount-code" };

        public static IResourceTypeId CartDiscount = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.CartDiscount, JsonName = "cart-discount" };

        public static IResourceTypeId CustomerGroup = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.CustomerGroup, JsonName = "customer-group" };

        public static IResourceTypeId Store = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Store, JsonName = "store" };

        ResourceTypeId? Value { get; }

        static IResourceTypeId[] Values()
        {
            return new[]
            {
                 Address ,
                 Asset ,
                 Category ,
                 Channel ,
                 Customer ,
                 Order ,
                 OrderEdit ,
                 InventoryEntry ,
                 LineItem ,
                 CustomLineItem ,
                 ProductPrice ,
                 Payment ,
                 PaymentInterfaceInteraction ,
                 Review ,
                 ShippingMethod ,
                 ShoppingList ,
                 ShoppingListTextLineItem ,
                 DiscountCode ,
                 CartDiscount ,
                 CustomerGroup ,
                 Store
             };
        }
        static IResourceTypeId FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ResourceTypeIdWrapper() { JsonName = value };
        }
    }
}
