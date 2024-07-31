using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ImportRequest))]
    [SubTypeDiscriminator("category", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.CategoryImportRequest))]
    [SubTypeDiscriminator("customer", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.CustomerImportRequest))]
    [SubTypeDiscriminator("discount-code", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.DiscountCodeImportRequest))]
    [SubTypeDiscriminator("inventory", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.InventoryImportRequest))]
    [SubTypeDiscriminator("order", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.OrderImportRequest))]
    [SubTypeDiscriminator("order-patch", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.OrderPatchImportRequest))]
    [SubTypeDiscriminator("price", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.PriceImportRequest))]
    [SubTypeDiscriminator("product", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductImportRequest))]
    [SubTypeDiscriminator("product-draft", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductDraftImportRequest))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductTypeImportRequest))]
    [SubTypeDiscriminator("product-variant", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductVariantImportRequest))]
    [SubTypeDiscriminator("product-variant-patch", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductVariantPatchRequest))]
    [SubTypeDiscriminator("standalone-price", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.StandalonePriceImportRequest))]
    [SubTypeDiscriminator("type", typeof(commercetools.Sdk.ImportApi.Models.Importrequests.TypeImportRequest))]
    public partial interface IImportRequest
    {
        IImportResourceType Type { get; set; }

        static commercetools.Sdk.ImportApi.Models.Importrequests.CategoryImportRequest Category(Action<commercetools.Sdk.ImportApi.Models.Importrequests.CategoryImportRequest> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Importrequests.CategoryImportRequest();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Importrequests.CustomerImportRequest Customer(Action<commercetools.Sdk.ImportApi.Models.Importrequests.CustomerImportRequest> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Importrequests.CustomerImportRequest();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Importrequests.DiscountCodeImportRequest DiscountCode(Action<commercetools.Sdk.ImportApi.Models.Importrequests.DiscountCodeImportRequest> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Importrequests.DiscountCodeImportRequest();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Importrequests.InventoryImportRequest Inventory(Action<commercetools.Sdk.ImportApi.Models.Importrequests.InventoryImportRequest> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Importrequests.InventoryImportRequest();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Importrequests.OrderImportRequest Order(Action<commercetools.Sdk.ImportApi.Models.Importrequests.OrderImportRequest> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Importrequests.OrderImportRequest();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Importrequests.OrderPatchImportRequest OrderPatch(Action<commercetools.Sdk.ImportApi.Models.Importrequests.OrderPatchImportRequest> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Importrequests.OrderPatchImportRequest();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Importrequests.PriceImportRequest Price(Action<commercetools.Sdk.ImportApi.Models.Importrequests.PriceImportRequest> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Importrequests.PriceImportRequest();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Importrequests.ProductImportRequest Product(Action<commercetools.Sdk.ImportApi.Models.Importrequests.ProductImportRequest> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Importrequests.ProductImportRequest();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Importrequests.ProductDraftImportRequest ProductDraft(Action<commercetools.Sdk.ImportApi.Models.Importrequests.ProductDraftImportRequest> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Importrequests.ProductDraftImportRequest();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Importrequests.ProductTypeImportRequest ProductType(Action<commercetools.Sdk.ImportApi.Models.Importrequests.ProductTypeImportRequest> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Importrequests.ProductTypeImportRequest();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Importrequests.ProductVariantImportRequest ProductVariant(Action<commercetools.Sdk.ImportApi.Models.Importrequests.ProductVariantImportRequest> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Importrequests.ProductVariantImportRequest();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Importrequests.ProductVariantPatchRequest ProductVariantPatch(Action<commercetools.Sdk.ImportApi.Models.Importrequests.ProductVariantPatchRequest> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Importrequests.ProductVariantPatchRequest();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Importrequests.StandalonePriceImportRequest StandalonePrice(Action<commercetools.Sdk.ImportApi.Models.Importrequests.StandalonePriceImportRequest> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Importrequests.StandalonePriceImportRequest();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Importrequests.TypeImportRequest _Type(Action<commercetools.Sdk.ImportApi.Models.Importrequests.TypeImportRequest> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Importrequests.TypeImportRequest();
            init?.Invoke(t);
            return t;
        }
    }
}
