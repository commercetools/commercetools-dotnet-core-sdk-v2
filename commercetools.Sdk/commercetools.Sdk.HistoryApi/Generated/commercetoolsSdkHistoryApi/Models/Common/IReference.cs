using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.HistoryApi.Models.Common.Reference))]
    [SubTypeDiscriminator("cart-discount", typeof(commercetools.Sdk.HistoryApi.Models.Common.CartDiscountReference))]
    [SubTypeDiscriminator("category", typeof(commercetools.Sdk.HistoryApi.Models.Common.CategoryReference))]
    [SubTypeDiscriminator("channel", typeof(commercetools.Sdk.HistoryApi.Models.Common.ChannelReference))]
    [SubTypeDiscriminator("customer", typeof(commercetools.Sdk.HistoryApi.Models.Common.CustomerReference))]
    [SubTypeDiscriminator("customer-group", typeof(commercetools.Sdk.HistoryApi.Models.Common.CustomerGroupReference))]
    [SubTypeDiscriminator("discount-code", typeof(commercetools.Sdk.HistoryApi.Models.Common.DiscountCodeReference))]
    [SubTypeDiscriminator("payment", typeof(commercetools.Sdk.HistoryApi.Models.Common.PaymentReference))]
    [SubTypeDiscriminator("product", typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductReference))]
    [SubTypeDiscriminator("product-discount", typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductDiscountReference))]
    [SubTypeDiscriminator("product-selection", typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductSelectionReference))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductTypeReference))]
    [SubTypeDiscriminator("recurrence-policy", typeof(commercetools.Sdk.HistoryApi.Models.Common.RecurrencePolicyReference))]
    [SubTypeDiscriminator("shipping-method", typeof(commercetools.Sdk.HistoryApi.Models.Common.ShippingMethodReference))]
    [SubTypeDiscriminator("state", typeof(commercetools.Sdk.HistoryApi.Models.Common.StateReference))]
    [SubTypeDiscriminator("tax-category", typeof(commercetools.Sdk.HistoryApi.Models.Common.TaxCategoryReference))]
    [SubTypeDiscriminator("type", typeof(commercetools.Sdk.HistoryApi.Models.Common.TypeReference))]
    public partial interface IReference
    {
        IReferenceTypeId TypeId { get; set; }

        string Id { get; set; }

        static commercetools.Sdk.HistoryApi.Models.Common.CartDiscountReference CartDiscount(Action<commercetools.Sdk.HistoryApi.Models.Common.CartDiscountReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.CartDiscountReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.CategoryReference Category(Action<commercetools.Sdk.HistoryApi.Models.Common.CategoryReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.CategoryReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.ChannelReference Channel(Action<commercetools.Sdk.HistoryApi.Models.Common.ChannelReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.ChannelReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.CustomerReference Customer(Action<commercetools.Sdk.HistoryApi.Models.Common.CustomerReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.CustomerReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.CustomerGroupReference CustomerGroup(Action<commercetools.Sdk.HistoryApi.Models.Common.CustomerGroupReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.CustomerGroupReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.DiscountCodeReference DiscountCode(Action<commercetools.Sdk.HistoryApi.Models.Common.DiscountCodeReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.DiscountCodeReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.PaymentReference Payment(Action<commercetools.Sdk.HistoryApi.Models.Common.PaymentReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.PaymentReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.ProductReference Product(Action<commercetools.Sdk.HistoryApi.Models.Common.ProductReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.ProductReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.ProductDiscountReference ProductDiscount(Action<commercetools.Sdk.HistoryApi.Models.Common.ProductDiscountReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.ProductDiscountReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.ProductSelectionReference ProductSelection(Action<commercetools.Sdk.HistoryApi.Models.Common.ProductSelectionReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.ProductSelectionReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.ProductTypeReference ProductType(Action<commercetools.Sdk.HistoryApi.Models.Common.ProductTypeReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.ProductTypeReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.RecurrencePolicyReference RecurrencePolicy(Action<commercetools.Sdk.HistoryApi.Models.Common.RecurrencePolicyReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.RecurrencePolicyReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.ShippingMethodReference ShippingMethod(Action<commercetools.Sdk.HistoryApi.Models.Common.ShippingMethodReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.ShippingMethodReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.StateReference State(Action<commercetools.Sdk.HistoryApi.Models.Common.StateReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.StateReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.TaxCategoryReference TaxCategory(Action<commercetools.Sdk.HistoryApi.Models.Common.TaxCategoryReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.TaxCategoryReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.TypeReference Type(Action<commercetools.Sdk.HistoryApi.Models.Common.TypeReference> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.TypeReference();
            init?.Invoke(t);
            return t;
        }
    }
}
