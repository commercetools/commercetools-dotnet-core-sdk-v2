using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderQueryBuilderDsl
    {
        public OrderQueryBuilderDsl()
        {
        }

        public static OrderQueryBuilderDsl Of()
        {
            return new OrderQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> OrderNumber()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderNumber")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> PurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("purchaseOrderNumber")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> CustomerId()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerId")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> CustomerEmail()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerEmail")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderQueryBuilderDsl> LineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderQueryBuilderDsl> LineItems()
        {
            return new CollectionPredicateBuilder<OrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItems")),
                    p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderQueryBuilderDsl> CustomLineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customLineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderQueryBuilderDsl> CustomLineItems()
        {
            return new CollectionPredicateBuilder<OrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItems")),
                    p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderQueryBuilderDsl> TotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderQueryBuilderDsl> TaxedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderQueryBuilderDsl> TaxedShippingPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedShippingPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderQueryBuilderDsl> DiscountOnTotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountOnTotalPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountOnTotalPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountOnTotalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountOnTotalPriceQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> TaxMode()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxMode")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> TaxRoundingMode()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxRoundingMode")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> TaxCalculationMode()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxCalculationMode")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> InventoryMode()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inventoryMode")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderQueryBuilderDsl> BillingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("billingAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderQueryBuilderDsl> ShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> ShippingMode()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingMode")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderQueryBuilderDsl> ShippingInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderQueryBuilderDsl> ShippingRateInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRateInput"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderQueryBuilderDsl> ShippingCustomFields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingCustomFields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderQueryBuilderDsl> Shipping(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shipping"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderQueryBuilderDsl> Shipping()
        {
            return new CollectionPredicateBuilder<OrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipping")),
                    p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderQueryBuilderDsl> ItemShippingAddresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("itemShippingAddresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderQueryBuilderDsl> ItemShippingAddresses()
        {
            return new CollectionPredicateBuilder<OrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("itemShippingAddresses")),
                    p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderQueryBuilderDsl> DiscountCodes(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountCodeInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountCodeInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountCodes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountCodeInfoQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderQueryBuilderDsl> DiscountCodes()
        {
            return new CollectionPredicateBuilder<OrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountCodes")),
                    p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderQueryBuilderDsl> DirectDiscounts(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("directDiscounts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderQueryBuilderDsl> DirectDiscounts()
        {
            return new CollectionPredicateBuilder<OrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("directDiscounts")),
                    p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderQueryBuilderDsl> RefusedGifts(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("refusedGifts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountReferenceQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderQueryBuilderDsl> RefusedGifts()
        {
            return new CollectionPredicateBuilder<OrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("refusedGifts")),
                    p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderQueryBuilderDsl> PaymentInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.PaymentInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.PaymentInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.PaymentInfoQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> Origin()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("origin")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderQueryBuilderDsl> Cart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("cart"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderQueryBuilderDsl> Quote(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("quote"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteReferenceQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> OrderState()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderState")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> ShipmentState()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipmentState")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, string> PaymentState()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentState")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderQueryBuilderDsl> SyncInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.SyncInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.SyncInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("syncInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.SyncInfoQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderQueryBuilderDsl> SyncInfo()
        {
            return new CollectionPredicateBuilder<OrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("syncInfo")),
                    p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderQueryBuilderDsl> ReturnInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("returnInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderQueryBuilderDsl> ReturnInfo()
        {
            return new CollectionPredicateBuilder<OrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnInfo")),
                    p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, long> LastMessageSequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastMessageSequenceNumber")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderQueryBuilderDsl, DateTime> CompletedAt()
        {
            return new ComparisonPredicateBuilder<OrderQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("completedAt")),
            p => new CombinationQueryPredicate<OrderQueryBuilderDsl>(p, OrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderQueryBuilderDsl.Of);
        }


        public CombinationQueryPredicate<OrderQueryBuilderDsl> AsStagedOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderQueryBuilderDsl.Of()),
                OrderQueryBuilderDsl.Of);
        }
    }
}
