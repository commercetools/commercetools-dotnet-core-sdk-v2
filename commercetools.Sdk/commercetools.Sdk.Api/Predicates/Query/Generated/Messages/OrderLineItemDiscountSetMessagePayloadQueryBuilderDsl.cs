using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl
    {
        public OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl>(p, OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl>(p, OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl>(p, OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl> DiscountedPricePerQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountedPricePerQuantity"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl.Of())),
                OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl> DiscountedPricePerQuantity()
        {
            return new CollectionPredicateBuilder<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountedPricePerQuantity")),
                    p => new CombinationQueryPredicate<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl>(p, OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl> TotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl> TaxedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl.Of())),
                OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl> TaxedPricePortions(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.MethodTaxedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.MethodTaxedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPricePortions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.MethodTaxedPriceQueryBuilderDsl.Of())),
                OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl> TaxedPricePortions()
        {
            return new CollectionPredicateBuilder<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxedPricePortions")),
                    p => new CombinationQueryPredicate<OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl>(p, OrderLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
