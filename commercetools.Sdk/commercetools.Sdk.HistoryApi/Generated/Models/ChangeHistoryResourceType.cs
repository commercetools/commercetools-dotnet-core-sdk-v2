using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.HistoryApi.Models
{
    public enum ChangeHistoryResourceType
    {
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

        [Description("inventory-entry")]
        InventoryEntry,

        [Description("order")]
        Order,

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

        [Description("shopping-list")]
        ShoppingList,

        [Description("state")]
        State,

        [Description("store")]
        Store,

        [Description("tax-category")]
        TaxCategory,

        [Description("type")]
        Type,

        [Description("zone")]
        Zone
    }
    public class ChangeHistoryResourceTypeWrapper : IChangeHistoryResourceType
    {
        public string JsonName { get; internal set; }
        public ChangeHistoryResourceType? Value { get; internal set; }
    }
    [EnumInterfaceCreator(typeof(IChangeHistoryResourceType), "FindEnum")]
    public interface IChangeHistoryResourceType : IJsonName
    {
        public static IChangeHistoryResourceType CartDiscount = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.CartDiscount, JsonName = "cart-discount" };

        public static IChangeHistoryResourceType Category = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.Category, JsonName = "category" };

        public static IChangeHistoryResourceType Channel = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.Channel, JsonName = "channel" };

        public static IChangeHistoryResourceType Customer = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.Customer, JsonName = "customer" };

        public static IChangeHistoryResourceType CustomerGroup = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.CustomerGroup, JsonName = "customer-group" };

        public static IChangeHistoryResourceType DiscountCode = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.DiscountCode, JsonName = "discount-code" };

        public static IChangeHistoryResourceType InventoryEntry = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.InventoryEntry, JsonName = "inventory-entry" };

        public static IChangeHistoryResourceType Order = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.Order, JsonName = "order" };

        public static IChangeHistoryResourceType Payment = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.Payment, JsonName = "payment" };

        public static IChangeHistoryResourceType Product = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.Product, JsonName = "product" };

        public static IChangeHistoryResourceType ProductDiscount = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.ProductDiscount, JsonName = "product-discount" };

        public static IChangeHistoryResourceType ProductType = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.ProductType, JsonName = "product-type" };

        public static IChangeHistoryResourceType Review = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.Review, JsonName = "review" };

        public static IChangeHistoryResourceType ShoppingList = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.ShoppingList, JsonName = "shopping-list" };

        public static IChangeHistoryResourceType State = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.State, JsonName = "state" };

        public static IChangeHistoryResourceType Store = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.Store, JsonName = "store" };

        public static IChangeHistoryResourceType TaxCategory = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.TaxCategory, JsonName = "tax-category" };

        public static IChangeHistoryResourceType Type = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.Type, JsonName = "type" };

        public static IChangeHistoryResourceType Zone = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.Zone, JsonName = "zone" };

        ChangeHistoryResourceType? Value { get; }

        static IChangeHistoryResourceType[] Values()
        {
            return new[]
            {
                CartDiscount ,
                Category ,
                Channel ,
                Customer ,
                CustomerGroup ,
                DiscountCode ,
                InventoryEntry ,
                Order ,
                Payment ,
                Product ,
                ProductDiscount ,
                ProductType ,
                Review ,
                ShoppingList ,
                State ,
                Store ,
                TaxCategory ,
                Type ,
                Zone
           };
        }
        static IChangeHistoryResourceType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ChangeHistoryResourceTypeWrapper() { JsonName = value };
        }
    }
}
