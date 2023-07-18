using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{
    public enum ChangeHistoryResourceType
    {
        [Description("associate-role")]
        AssociateRole,

        [Description("business-unit")]
        BusinessUnit,

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

        [Description("key-value-document")]
        KeyValueDocument,

        [Description("order")]
        Order,

        [Description("payment")]
        Payment,

        [Description("product")]
        Product,

        [Description("product-discount")]
        ProductDiscount,

        [Description("product-selection")]
        ProductSelection,

        [Description("product-type")]
        ProductType,

        [Description("quote-request")]
        QuoteRequest,

        [Description("quote")]
        Quote,

        [Description("review")]
        Review,

        [Description("shopping-list")]
        ShoppingList,

        [Description("staged-quote")]
        StagedQuote,

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
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(IChangeHistoryResourceType), "FindEnum")]
    public interface IChangeHistoryResourceType : IJsonName, IEnumerable<char>
    {
        public static IChangeHistoryResourceType AssociateRole = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.AssociateRole, JsonName = "associate-role" };

        public static IChangeHistoryResourceType BusinessUnit = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.BusinessUnit, JsonName = "business-unit" };

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

        public static IChangeHistoryResourceType KeyValueDocument = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.KeyValueDocument, JsonName = "key-value-document" };

        public static IChangeHistoryResourceType Order = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.Order, JsonName = "order" };

        public static IChangeHistoryResourceType Payment = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.Payment, JsonName = "payment" };

        public static IChangeHistoryResourceType Product = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.Product, JsonName = "product" };

        public static IChangeHistoryResourceType ProductDiscount = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.ProductDiscount, JsonName = "product-discount" };

        public static IChangeHistoryResourceType ProductSelection = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.ProductSelection, JsonName = "product-selection" };

        public static IChangeHistoryResourceType ProductType = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.ProductType, JsonName = "product-type" };

        public static IChangeHistoryResourceType QuoteRequest = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.QuoteRequest, JsonName = "quote-request" };

        public static IChangeHistoryResourceType Quote = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.Quote, JsonName = "quote" };

        public static IChangeHistoryResourceType Review = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.Review, JsonName = "review" };

        public static IChangeHistoryResourceType ShoppingList = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.ShoppingList, JsonName = "shopping-list" };

        public static IChangeHistoryResourceType StagedQuote = new ChangeHistoryResourceTypeWrapper
        { Value = ChangeHistoryResourceType.StagedQuote, JsonName = "staged-quote" };

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
                 AssociateRole ,
                 BusinessUnit ,
                 CartDiscount ,
                 Category ,
                 Channel ,
                 Customer ,
                 CustomerGroup ,
                 DiscountCode ,
                 InventoryEntry ,
                 KeyValueDocument ,
                 Order ,
                 Payment ,
                 Product ,
                 ProductDiscount ,
                 ProductSelection ,
                 ProductType ,
                 QuoteRequest ,
                 Quote ,
                 Review ,
                 ShoppingList ,
                 StagedQuote ,
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
