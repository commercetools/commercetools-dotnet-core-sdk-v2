using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.ImportApi.Models.Common.KeyReference))]
    [SubTypeDiscriminator("cart", typeof(commercetools.Sdk.ImportApi.Models.Common.CartKeyReference))]
    [SubTypeDiscriminator("cart-discount", typeof(commercetools.Sdk.ImportApi.Models.Common.CartDiscountKeyReference))]
    [SubTypeDiscriminator("category", typeof(commercetools.Sdk.ImportApi.Models.Common.CategoryKeyReference))]
    [SubTypeDiscriminator("channel", typeof(commercetools.Sdk.ImportApi.Models.Common.ChannelKeyReference))]
    [SubTypeDiscriminator("customer", typeof(commercetools.Sdk.ImportApi.Models.Common.CustomerKeyReference))]
    [SubTypeDiscriminator("customer-group", typeof(commercetools.Sdk.ImportApi.Models.Common.CustomerGroupKeyReference))]
    [SubTypeDiscriminator("discount-code", typeof(commercetools.Sdk.ImportApi.Models.Common.DiscountCodeKeyReference))]
    [SubTypeDiscriminator("key-value-document", typeof(commercetools.Sdk.ImportApi.Models.Common.CustomObjectKeyReference))]
    [SubTypeDiscriminator("order", typeof(commercetools.Sdk.ImportApi.Models.Common.OrderKeyReference))]
    [SubTypeDiscriminator("payment", typeof(commercetools.Sdk.ImportApi.Models.Common.PaymentKeyReference))]
    [SubTypeDiscriminator("price", typeof(commercetools.Sdk.ImportApi.Models.Common.PriceKeyReference))]
    [SubTypeDiscriminator("product", typeof(commercetools.Sdk.ImportApi.Models.Common.ProductKeyReference))]
    [SubTypeDiscriminator("product-discount", typeof(commercetools.Sdk.ImportApi.Models.Common.ProductDiscountKeyReference))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.Sdk.ImportApi.Models.Common.ProductTypeKeyReference))]
    [SubTypeDiscriminator("product-variant", typeof(commercetools.Sdk.ImportApi.Models.Common.ProductVariantKeyReference))]
    [SubTypeDiscriminator("shipping-method", typeof(commercetools.Sdk.ImportApi.Models.Common.ShippingMethodKeyReference))]
    [SubTypeDiscriminator("state", typeof(commercetools.Sdk.ImportApi.Models.Common.StateKeyReference))]
    [SubTypeDiscriminator("store", typeof(commercetools.Sdk.ImportApi.Models.Common.StoreKeyReference))]
    [SubTypeDiscriminator("tax-category", typeof(commercetools.Sdk.ImportApi.Models.Common.TaxCategoryKeyReference))]
    [SubTypeDiscriminator("type", typeof(commercetools.Sdk.ImportApi.Models.Common.TypeKeyReference))]
    public partial interface IKeyReference
    {
        string Key { get; set; }

        IReferenceType TypeId { get; set; }

        static commercetools.Sdk.ImportApi.Models.Common.CartKeyReference Cart(Action<commercetools.Sdk.ImportApi.Models.Common.CartKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.CartKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.CartDiscountKeyReference CartDiscount(Action<commercetools.Sdk.ImportApi.Models.Common.CartDiscountKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.CartDiscountKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.CategoryKeyReference Category(Action<commercetools.Sdk.ImportApi.Models.Common.CategoryKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.CategoryKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.ChannelKeyReference Channel(Action<commercetools.Sdk.ImportApi.Models.Common.ChannelKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.ChannelKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.CustomerKeyReference Customer(Action<commercetools.Sdk.ImportApi.Models.Common.CustomerKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.CustomerKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.CustomerGroupKeyReference CustomerGroup(Action<commercetools.Sdk.ImportApi.Models.Common.CustomerGroupKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.CustomerGroupKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.DiscountCodeKeyReference DiscountCode(Action<commercetools.Sdk.ImportApi.Models.Common.DiscountCodeKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.DiscountCodeKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.CustomObjectKeyReference KeyValueDocument(Action<commercetools.Sdk.ImportApi.Models.Common.CustomObjectKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.CustomObjectKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.OrderKeyReference Order(Action<commercetools.Sdk.ImportApi.Models.Common.OrderKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.OrderKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.PaymentKeyReference Payment(Action<commercetools.Sdk.ImportApi.Models.Common.PaymentKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.PaymentKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.PriceKeyReference Price(Action<commercetools.Sdk.ImportApi.Models.Common.PriceKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.PriceKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.ProductKeyReference Product(Action<commercetools.Sdk.ImportApi.Models.Common.ProductKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.ProductKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.ProductDiscountKeyReference ProductDiscount(Action<commercetools.Sdk.ImportApi.Models.Common.ProductDiscountKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.ProductDiscountKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.ProductTypeKeyReference ProductType(Action<commercetools.Sdk.ImportApi.Models.Common.ProductTypeKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.ProductTypeKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.ProductVariantKeyReference ProductVariant(Action<commercetools.Sdk.ImportApi.Models.Common.ProductVariantKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.ProductVariantKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.ShippingMethodKeyReference ShippingMethod(Action<commercetools.Sdk.ImportApi.Models.Common.ShippingMethodKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.ShippingMethodKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.StateKeyReference State(Action<commercetools.Sdk.ImportApi.Models.Common.StateKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.StateKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.StoreKeyReference Store(Action<commercetools.Sdk.ImportApi.Models.Common.StoreKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.StoreKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.TaxCategoryKeyReference TaxCategory(Action<commercetools.Sdk.ImportApi.Models.Common.TaxCategoryKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.TaxCategoryKeyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.TypeKeyReference Type(Action<commercetools.Sdk.ImportApi.Models.Common.TypeKeyReference> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.TypeKeyReference();
            init?.Invoke(t);
            return t;
        }
    }
}
