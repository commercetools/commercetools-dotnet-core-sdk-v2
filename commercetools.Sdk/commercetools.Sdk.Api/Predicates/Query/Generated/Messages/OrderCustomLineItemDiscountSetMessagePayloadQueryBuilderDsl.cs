using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl
    {
        public OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl>(p, OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl>(p, OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl>(p, OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl> DiscountedPricePerQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountedPricePerQuantity"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl.Of())),
                OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl> DiscountedPricePerQuantity()
        {
            return new CollectionPredicateBuilder<OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountedPricePerQuantity")),
                    p => new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl>(p, OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl> TaxedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl.Of())),
                OrderCustomLineItemDiscountSetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
