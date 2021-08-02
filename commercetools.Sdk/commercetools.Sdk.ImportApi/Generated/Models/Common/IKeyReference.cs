using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.ImportApi.Models.Common.KeyReference))]
    [SubTypeDiscriminator("cart", typeof(commercetools.ImportApi.Models.Common.CartKeyReference))]
    [SubTypeDiscriminator("cart-discount", typeof(commercetools.ImportApi.Models.Common.CartDiscountKeyReference))]
    [SubTypeDiscriminator("category", typeof(commercetools.ImportApi.Models.Common.CategoryKeyReference))]
    [SubTypeDiscriminator("channel", typeof(commercetools.ImportApi.Models.Common.ChannelKeyReference))]
    [SubTypeDiscriminator("customer", typeof(commercetools.ImportApi.Models.Common.CustomerKeyReference))]
    [SubTypeDiscriminator("customer-group", typeof(commercetools.ImportApi.Models.Common.CustomerGroupKeyReference))]
    [SubTypeDiscriminator("discount-code", typeof(commercetools.ImportApi.Models.Common.DiscountCodeKeyReference))]
    [SubTypeDiscriminator("order", typeof(commercetools.ImportApi.Models.Common.OrderKeyReference))]
    [SubTypeDiscriminator("payment", typeof(commercetools.ImportApi.Models.Common.PaymentKeyReference))]
    [SubTypeDiscriminator("price", typeof(commercetools.ImportApi.Models.Common.PriceKeyReference))]
    [SubTypeDiscriminator("product", typeof(commercetools.ImportApi.Models.Common.ProductKeyReference))]
    [SubTypeDiscriminator("product-discount", typeof(commercetools.ImportApi.Models.Common.ProductDiscountKeyReference))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.ImportApi.Models.Common.ProductTypeKeyReference))]
    [SubTypeDiscriminator("product-variant", typeof(commercetools.ImportApi.Models.Common.ProductVariantKeyReference))]
    [SubTypeDiscriminator("shipping-method", typeof(commercetools.ImportApi.Models.Common.ShippingMethodKeyReference))]
    [SubTypeDiscriminator("state", typeof(commercetools.ImportApi.Models.Common.StateKeyReference))]
    [SubTypeDiscriminator("store", typeof(commercetools.ImportApi.Models.Common.StoreKeyReference))]
    [SubTypeDiscriminator("tax-category", typeof(commercetools.ImportApi.Models.Common.TaxCategoryKeyReference))]
    [SubTypeDiscriminator("type", typeof(commercetools.ImportApi.Models.Common.TypeKeyReference))]
    public partial interface IKeyReference 
    {
        string Key { get; set;}
        
        IReferenceType TypeId { get; set;}
    }
}
