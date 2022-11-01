using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.ImportApi.Models.Common
{
    public enum ImportResourceType
    {
        [Description("category")]
        Category,

        [Description("order")]
        Order,

        [Description("order-patch")]
        OrderPatch,

        [Description("price")]
        Price,

        [Description("product")]
        Product,

        [Description("product-draft")]
        ProductDraft,

        [Description("product-type")]
        ProductType,

        [Description("product-variant")]
        ProductVariant,

        [Description("product-variant-patch")]
        ProductVariantPatch,

        [Description("customer")]
        Customer,

        [Description("inventory")]
        Inventory,

        [Description("standalone-price")]
        StandalonePrice
    }

    public class ImportResourceTypeWrapper : IImportResourceType
    {
        public string JsonName { get; internal set; }
        public ImportResourceType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IImportResourceType), "FindEnum")]
    public interface IImportResourceType : IJsonName, IEnumerable<char>
    {
        public static IImportResourceType Category = new ImportResourceTypeWrapper
        { Value = ImportResourceType.Category, JsonName = "category" };

        public static IImportResourceType Order = new ImportResourceTypeWrapper
        { Value = ImportResourceType.Order, JsonName = "order" };

        public static IImportResourceType OrderPatch = new ImportResourceTypeWrapper
        { Value = ImportResourceType.OrderPatch, JsonName = "order-patch" };

        public static IImportResourceType Price = new ImportResourceTypeWrapper
        { Value = ImportResourceType.Price, JsonName = "price" };

        public static IImportResourceType Product = new ImportResourceTypeWrapper
        { Value = ImportResourceType.Product, JsonName = "product" };

        public static IImportResourceType ProductDraft = new ImportResourceTypeWrapper
        { Value = ImportResourceType.ProductDraft, JsonName = "product-draft" };

        public static IImportResourceType ProductType = new ImportResourceTypeWrapper
        { Value = ImportResourceType.ProductType, JsonName = "product-type" };

        public static IImportResourceType ProductVariant = new ImportResourceTypeWrapper
        { Value = ImportResourceType.ProductVariant, JsonName = "product-variant" };

        public static IImportResourceType ProductVariantPatch = new ImportResourceTypeWrapper
        { Value = ImportResourceType.ProductVariantPatch, JsonName = "product-variant-patch" };

        public static IImportResourceType Customer = new ImportResourceTypeWrapper
        { Value = ImportResourceType.Customer, JsonName = "customer" };

        public static IImportResourceType Inventory = new ImportResourceTypeWrapper
        { Value = ImportResourceType.Inventory, JsonName = "inventory" };

        public static IImportResourceType StandalonePrice = new ImportResourceTypeWrapper
        { Value = ImportResourceType.StandalonePrice, JsonName = "standalone-price" };

        ImportResourceType? Value { get; }

        static IImportResourceType[] Values()
        {
            return new[]
            {
                 Category ,
                 Order ,
                 OrderPatch ,
                 Price ,
                 Product ,
                 ProductDraft ,
                 ProductType ,
                 ProductVariant ,
                 ProductVariantPatch ,
                 Customer ,
                 Inventory ,
                 StandalonePrice
             };
        }
        static IImportResourceType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ImportResourceTypeWrapper() { JsonName = value };
        }
    }
}
