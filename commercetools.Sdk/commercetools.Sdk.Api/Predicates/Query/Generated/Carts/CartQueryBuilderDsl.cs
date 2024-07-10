using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartQueryBuilderDsl
    {
        public CartQueryBuilderDsl()
        {
        }

        public static CartQueryBuilderDsl Of()
        {
            return new CartQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartQueryBuilderDsl, string> CustomerId()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerId")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartQueryBuilderDsl, string> CustomerEmail()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerEmail")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartQueryBuilderDsl> LineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartQueryBuilderDsl> LineItems()
        {
            return new CollectionPredicateBuilder<CartQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItems")),
                    p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CartQueryBuilderDsl> CustomLineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customLineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartQueryBuilderDsl> CustomLineItems()
        {
            return new CollectionPredicateBuilder<CartQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItems")),
                    p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<CartQueryBuilderDsl, long> TotalLineItemQuantity()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("totalLineItemQuantity")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartQueryBuilderDsl> TotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartQueryBuilderDsl> TaxedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartQueryBuilderDsl> TaxedShippingPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedShippingPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartQueryBuilderDsl> DiscountOnTotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountOnTotalPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountOnTotalPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountOnTotalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountOnTotalPriceQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartQueryBuilderDsl, string> TaxMode()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxMode")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartQueryBuilderDsl, string> TaxRoundingMode()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxRoundingMode")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartQueryBuilderDsl, string> TaxCalculationMode()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxCalculationMode")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartQueryBuilderDsl, string> InventoryMode()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inventoryMode")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartQueryBuilderDsl, string> CartState()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartState")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartQueryBuilderDsl> BillingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("billingAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartQueryBuilderDsl> ShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartQueryBuilderDsl, string> ShippingMode()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingMode")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartQueryBuilderDsl> ShippingInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartQueryBuilderDsl> ShippingRateInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRateInput"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartQueryBuilderDsl> ShippingCustomFields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingCustomFields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartQueryBuilderDsl> Shipping(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shipping"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartQueryBuilderDsl> Shipping()
        {
            return new CollectionPredicateBuilder<CartQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipping")),
                    p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CartQueryBuilderDsl> ItemShippingAddresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("itemShippingAddresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartQueryBuilderDsl> ItemShippingAddresses()
        {
            return new CollectionPredicateBuilder<CartQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("itemShippingAddresses")),
                    p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CartQueryBuilderDsl> DiscountCodes(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountCodeInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountCodeInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountCodes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountCodeInfoQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartQueryBuilderDsl> DiscountCodes()
        {
            return new CollectionPredicateBuilder<CartQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountCodes")),
                    p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CartQueryBuilderDsl> DirectDiscounts(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("directDiscounts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartQueryBuilderDsl> DirectDiscounts()
        {
            return new CollectionPredicateBuilder<CartQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("directDiscounts")),
                    p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CartQueryBuilderDsl> RefusedGifts(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("refusedGifts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountReferenceQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartQueryBuilderDsl> RefusedGifts()
        {
            return new CollectionPredicateBuilder<CartQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("refusedGifts")),
                    p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CartQueryBuilderDsl> PaymentInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.PaymentInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.PaymentInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.PaymentInfoQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartQueryBuilderDsl, string> Origin()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("origin")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartQueryBuilderDsl, long> DeleteDaysAfterLastModification()
        {
            return new ComparisonPredicateBuilder<CartQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deleteDaysAfterLastModification")),
            p => new CombinationQueryPredicate<CartQueryBuilderDsl>(p, CartQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CartQueryBuilderDsl.Of);
        }


    }
}
