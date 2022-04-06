using commercetools.Base.CustomAttributes;


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
    }
}
