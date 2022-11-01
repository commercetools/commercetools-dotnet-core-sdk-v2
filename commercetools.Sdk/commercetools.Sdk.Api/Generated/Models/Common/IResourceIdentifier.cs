using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Common.ResourceIdentifier))]
    [SubTypeDiscriminator("business-unit", typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitResourceIdentifier))]
    [SubTypeDiscriminator("cart", typeof(commercetools.Sdk.Api.Models.Carts.CartResourceIdentifier))]
    [SubTypeDiscriminator("cart-discount", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountResourceIdentifier))]
    [SubTypeDiscriminator("category", typeof(commercetools.Sdk.Api.Models.Categories.CategoryResourceIdentifier))]
    [SubTypeDiscriminator("channel", typeof(commercetools.Sdk.Api.Models.Channels.ChannelResourceIdentifier))]
    [SubTypeDiscriminator("customer", typeof(commercetools.Sdk.Api.Models.Customers.CustomerResourceIdentifier))]
    [SubTypeDiscriminator("customer-group", typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupResourceIdentifier))]
    [SubTypeDiscriminator("discount-code", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeResourceIdentifier))]
    [SubTypeDiscriminator("inventory-entry", typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryResourceIdentifier))]
    [SubTypeDiscriminator("order", typeof(commercetools.Sdk.Api.Models.Orders.OrderResourceIdentifier))]
    [SubTypeDiscriminator("order-edit", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditResourceIdentifier))]
    [SubTypeDiscriminator("payment", typeof(commercetools.Sdk.Api.Models.Payments.PaymentResourceIdentifier))]
    [SubTypeDiscriminator("product", typeof(commercetools.Sdk.Api.Models.Products.ProductResourceIdentifier))]
    [SubTypeDiscriminator("product-discount", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountResourceIdentifier))]
    [SubTypeDiscriminator("product-selection", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionResourceIdentifier))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeResourceIdentifier))]
    [SubTypeDiscriminator("quote", typeof(commercetools.Sdk.Api.Models.Quotes.QuoteResourceIdentifier))]
    [SubTypeDiscriminator("quote-request", typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestResourceIdentifier))]
    [SubTypeDiscriminator("review", typeof(commercetools.Sdk.Api.Models.Reviews.ReviewResourceIdentifier))]
    [SubTypeDiscriminator("shipping-method", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodResourceIdentifier))]
    [SubTypeDiscriminator("shopping-list", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListResourceIdentifier))]
    [SubTypeDiscriminator("staged-quote", typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteResourceIdentifier))]
    [SubTypeDiscriminator("standalone-price", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceResourceIdentifier))]
    [SubTypeDiscriminator("state", typeof(commercetools.Sdk.Api.Models.States.StateResourceIdentifier))]
    [SubTypeDiscriminator("store", typeof(commercetools.Sdk.Api.Models.Stores.StoreResourceIdentifier))]
    [SubTypeDiscriminator("tax-category", typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryResourceIdentifier))]
    [SubTypeDiscriminator("type", typeof(commercetools.Sdk.Api.Models.Types.TypeResourceIdentifier))]
    [SubTypeDiscriminator("zone", typeof(commercetools.Sdk.Api.Models.Zones.ZoneResourceIdentifier))]
    public partial interface IResourceIdentifier
    {
        IReferenceTypeId TypeId { get; set; }

        string Id { get; set; }

        string Key { get; set; }

        static commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitResourceIdentifier BusinessUnit(Action<commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Carts.CartResourceIdentifier Cart(Action<commercetools.Sdk.Api.Models.Carts.CartResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Carts.CartResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountResourceIdentifier CartDiscount(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategoryResourceIdentifier Category(Action<commercetools.Sdk.Api.Models.Categories.CategoryResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategoryResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Channels.ChannelResourceIdentifier Channel(Action<commercetools.Sdk.Api.Models.Channels.ChannelResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Channels.ChannelResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Customers.CustomerResourceIdentifier Customer(Action<commercetools.Sdk.Api.Models.Customers.CustomerResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Customers.CustomerResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupResourceIdentifier CustomerGroup(Action<commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeResourceIdentifier DiscountCode(Action<commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Inventories.InventoryEntryResourceIdentifier InventoryEntry(Action<commercetools.Sdk.Api.Models.Inventories.InventoryEntryResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Inventories.InventoryEntryResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Orders.OrderResourceIdentifier Order(Action<commercetools.Sdk.Api.Models.Orders.OrderResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Orders.OrderResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.OrderEditResourceIdentifier OrderEdit(Action<commercetools.Sdk.Api.Models.OrderEdits.OrderEditResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.OrderEditResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Payments.PaymentResourceIdentifier Payment(Action<commercetools.Sdk.Api.Models.Payments.PaymentResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Payments.PaymentResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductResourceIdentifier Product(Action<commercetools.Sdk.Api.Models.Products.ProductResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountResourceIdentifier ProductDiscount(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionResourceIdentifier ProductSelection(Action<commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.ProductTypeResourceIdentifier ProductType(Action<commercetools.Sdk.Api.Models.ProductTypes.ProductTypeResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.ProductTypeResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Quotes.QuoteResourceIdentifier Quote(Action<commercetools.Sdk.Api.Models.Quotes.QuoteResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Quotes.QuoteResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestResourceIdentifier QuoteRequest(Action<commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Reviews.ReviewResourceIdentifier Review(Action<commercetools.Sdk.Api.Models.Reviews.ReviewResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Reviews.ReviewResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodResourceIdentifier ShippingMethod(Action<commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListResourceIdentifier ShoppingList(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteResourceIdentifier StagedQuote(Action<commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceResourceIdentifier StandalonePrice(Action<commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.States.StateResourceIdentifier State(Action<commercetools.Sdk.Api.Models.States.StateResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.States.StateResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreResourceIdentifier Store(Action<commercetools.Sdk.Api.Models.Stores.StoreResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryResourceIdentifier TaxCategory(Action<commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.TypeResourceIdentifier Type(Action<commercetools.Sdk.Api.Models.Types.TypeResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.TypeResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Zones.ZoneResourceIdentifier Zone(Action<commercetools.Sdk.Api.Models.Zones.ZoneResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Zones.ZoneResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
    }
}
