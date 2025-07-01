using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Common.Reference))]
    [SubTypeDiscriminator("associate-role", typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleReference))]
    [SubTypeDiscriminator("attribute-group", typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupReference))]
    [SubTypeDiscriminator("business-unit", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitReference))]
    [SubTypeDiscriminator("cart", typeof(commercetools.Sdk.Api.Models.Carts.CartReference))]
    [SubTypeDiscriminator("cart-discount", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountReference))]
    [SubTypeDiscriminator("category", typeof(commercetools.Sdk.Api.Models.Categories.CategoryReference))]
    [SubTypeDiscriminator("channel", typeof(commercetools.Sdk.Api.Models.Channels.ChannelReference))]
    [SubTypeDiscriminator("customer", typeof(commercetools.Sdk.Api.Models.Customers.CustomerReference))]
    [SubTypeDiscriminator("customer-email-token", typeof(commercetools.Sdk.Api.Models.Customers.CustomerEmailTokenReference))]
    [SubTypeDiscriminator("customer-group", typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupReference))]
    [SubTypeDiscriminator("customer-password-token", typeof(commercetools.Sdk.Api.Models.Customers.CustomerPasswordTokenReference))]
    [SubTypeDiscriminator("direct-discount", typeof(commercetools.Sdk.Api.Models.Carts.DirectDiscountReference))]
    [SubTypeDiscriminator("discount-code", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeReference))]
    [SubTypeDiscriminator("discount-group", typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupReference))]
    [SubTypeDiscriminator("inventory-entry", typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryReference))]
    [SubTypeDiscriminator("key-value-document", typeof(commercetools.Sdk.Api.Models.CustomObjects.CustomObjectReference))]
    [SubTypeDiscriminator("order", typeof(commercetools.Sdk.Api.Models.Orders.OrderReference))]
    [SubTypeDiscriminator("order-edit", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditReference))]
    [SubTypeDiscriminator("payment", typeof(commercetools.Sdk.Api.Models.Payments.PaymentReference))]
    [SubTypeDiscriminator("payment-method", typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodReference))]
    [SubTypeDiscriminator("product", typeof(commercetools.Sdk.Api.Models.Products.ProductReference))]
    [SubTypeDiscriminator("product-discount", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountReference))]
    [SubTypeDiscriminator("product-selection", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionReference))]
    [SubTypeDiscriminator("product-tailoring", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringReference))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeReference))]
    [SubTypeDiscriminator("quote", typeof(commercetools.Sdk.Api.Models.Quotes.QuoteReference))]
    [SubTypeDiscriminator("quote-request", typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestReference))]
    [SubTypeDiscriminator("review", typeof(commercetools.Sdk.Api.Models.Reviews.ReviewReference))]
    [SubTypeDiscriminator("shipping-method", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodReference))]
    [SubTypeDiscriminator("shopping-list", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListReference))]
    [SubTypeDiscriminator("staged-quote", typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteReference))]
    [SubTypeDiscriminator("standalone-price", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceReference))]
    [SubTypeDiscriminator("state", typeof(commercetools.Sdk.Api.Models.States.StateReference))]
    [SubTypeDiscriminator("store", typeof(commercetools.Sdk.Api.Models.Stores.StoreReference))]
    [SubTypeDiscriminator("tax-category", typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryReference))]
    [SubTypeDiscriminator("type", typeof(commercetools.Sdk.Api.Models.Types.TypeReference))]
    [SubTypeDiscriminator("zone", typeof(commercetools.Sdk.Api.Models.Zones.ZoneReference))]
    public partial interface IReference
    {
        IReferenceTypeId TypeId { get; set; }

        string Id { get; set; }

        static commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleReference AssociateRole(Action<commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupReference AttributeGroup(Action<commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitReference BusinessUnit(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartReference Cart(Action<commercetools.Sdk.Api.Models.Carts.CartReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountReference CartDiscount(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategoryReference Category(Action<commercetools.Sdk.Api.Models.Categories.CategoryReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategoryReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Channels.ChannelReference Channel(Action<commercetools.Sdk.Api.Models.Channels.ChannelReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Channels.ChannelReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerReference Customer(Action<commercetools.Sdk.Api.Models.Customers.CustomerReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerEmailTokenReference CustomerEmailToken(Action<commercetools.Sdk.Api.Models.Customers.CustomerEmailTokenReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerEmailTokenReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupReference CustomerGroup(Action<commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerPasswordTokenReference CustomerPasswordToken(Action<commercetools.Sdk.Api.Models.Customers.CustomerPasswordTokenReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerPasswordTokenReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.DirectDiscountReference DirectDiscount(Action<commercetools.Sdk.Api.Models.Carts.DirectDiscountReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.DirectDiscountReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeReference DiscountCode(Action<commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupReference DiscountGroup(Action<commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Inventories.InventoryEntryReference InventoryEntry(Action<commercetools.Sdk.Api.Models.Inventories.InventoryEntryReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Inventories.InventoryEntryReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CustomObjects.CustomObjectReference KeyValueDocument(Action<commercetools.Sdk.Api.Models.CustomObjects.CustomObjectReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CustomObjects.CustomObjectReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderReference Order(Action<commercetools.Sdk.Api.Models.Orders.OrderReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.OrderEditReference OrderEdit(Action<commercetools.Sdk.Api.Models.OrderEdits.OrderEditReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.OrderEditReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentReference Payment(Action<commercetools.Sdk.Api.Models.Payments.PaymentReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodReference PaymentMethod(Action<commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductReference Product(Action<commercetools.Sdk.Api.Models.Products.ProductReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountReference ProductDiscount(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionReference ProductSelection(Action<commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringReference ProductTailoring(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeReference ProductType(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Quotes.QuoteReference Quote(Action<commercetools.Sdk.Api.Models.Quotes.QuoteReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Quotes.QuoteReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestReference QuoteRequest(Action<commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Reviews.ReviewReference Review(Action<commercetools.Sdk.Api.Models.Reviews.ReviewReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Reviews.ReviewReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodReference ShippingMethod(Action<commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListReference ShoppingList(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteReference StagedQuote(Action<commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceReference StandalonePrice(Action<commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.States.StateReference State(Action<commercetools.Sdk.Api.Models.States.StateReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.States.StateReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreReference Store(Action<commercetools.Sdk.Api.Models.Stores.StoreReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryReference TaxCategory(Action<commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.TypeReference Type(Action<commercetools.Sdk.Api.Models.Types.TypeReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.TypeReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Zones.ZoneReference Zone(Action<commercetools.Sdk.Api.Models.Zones.ZoneReference> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Zones.ZoneReference();
            init?.Invoke(t);
            return t;
        }
    }
}
