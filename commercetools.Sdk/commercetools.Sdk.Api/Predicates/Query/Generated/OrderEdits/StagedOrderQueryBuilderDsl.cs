using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderQueryBuilderDsl
    {
        public StagedOrderQueryBuilderDsl()
        {
        }

        public static StagedOrderQueryBuilderDsl Of()
        {
            return new StagedOrderQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> OrderNumber()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderNumber")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> PurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("purchaseOrderNumber")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> CustomerId()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerId")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> CustomerEmail()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerEmail")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> LineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderQueryBuilderDsl> LineItems()
        {
            return new CollectionPredicateBuilder<StagedOrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItems")),
                    p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> CustomLineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customLineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderQueryBuilderDsl> CustomLineItems()
        {
            return new CollectionPredicateBuilder<StagedOrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItems")),
                    p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> TotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> TaxedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> TaxedShippingPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedShippingPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> DiscountOnTotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountOnTotalPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountOnTotalPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountOnTotalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountOnTotalPriceQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> TaxMode()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxMode")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> TaxRoundingMode()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxRoundingMode")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> TaxCalculationMode()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxCalculationMode")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> InventoryMode()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inventoryMode")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> BillingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("billingAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> ShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> ShippingMode()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingMode")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> ShippingInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> ShippingRateInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRateInput"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> ShippingCustomFields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingCustomFields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> Shipping(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shipping"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderQueryBuilderDsl> Shipping()
        {
            return new CollectionPredicateBuilder<StagedOrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipping")),
                    p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> ItemShippingAddresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("itemShippingAddresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderQueryBuilderDsl> ItemShippingAddresses()
        {
            return new CollectionPredicateBuilder<StagedOrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("itemShippingAddresses")),
                    p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> DiscountCodes(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountCodeInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountCodeInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountCodes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountCodeInfoQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderQueryBuilderDsl> DiscountCodes()
        {
            return new CollectionPredicateBuilder<StagedOrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountCodes")),
                    p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> DirectDiscounts(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("directDiscounts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderQueryBuilderDsl> DirectDiscounts()
        {
            return new CollectionPredicateBuilder<StagedOrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("directDiscounts")),
                    p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> RefusedGifts(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("refusedGifts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountReferenceQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderQueryBuilderDsl> RefusedGifts()
        {
            return new CollectionPredicateBuilder<StagedOrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("refusedGifts")),
                    p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> PaymentInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.PaymentInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.PaymentInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.PaymentInfoQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> Origin()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("origin")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> Cart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("cart"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> Quote(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("quote"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteReferenceQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> OrderState()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderState")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> ShipmentState()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipmentState")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string> PaymentState()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentState")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> SyncInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.SyncInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.SyncInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("syncInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.SyncInfoQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderQueryBuilderDsl> SyncInfo()
        {
            return new CollectionPredicateBuilder<StagedOrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("syncInfo")),
                    p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> ReturnInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("returnInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderQueryBuilderDsl> ReturnInfo()
        {
            return new CollectionPredicateBuilder<StagedOrderQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnInfo")),
                    p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, long> LastMessageSequenceNumber()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastMessageSequenceNumber")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, DateTime> CompletedAt()
        {
            return new ComparisonPredicateBuilder<StagedOrderQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("completedAt")),
            p => new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(p, StagedOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StagedOrderQueryBuilderDsl.Of);
        }


    }
}
