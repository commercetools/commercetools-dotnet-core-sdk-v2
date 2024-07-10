using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class DiscountedLineItemPriceQueryBuilderDsl
    {
        public DiscountedLineItemPriceQueryBuilderDsl()
        {
        }

        public static DiscountedLineItemPriceQueryBuilderDsl Of()
        {
            return new DiscountedLineItemPriceQueryBuilderDsl();
        }

        public CombinationQueryPredicate<DiscountedLineItemPriceQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountedLineItemPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl.Of())),
                DiscountedLineItemPriceQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountedLineItemPriceQueryBuilderDsl> IncludedDiscounts(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPortionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPortionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountedLineItemPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("includedDiscounts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPortionQueryBuilderDsl.Of())),
                DiscountedLineItemPriceQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DiscountedLineItemPriceQueryBuilderDsl> IncludedDiscounts()
        {
            return new CollectionPredicateBuilder<DiscountedLineItemPriceQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("includedDiscounts")),
                    p => new CombinationQueryPredicate<DiscountedLineItemPriceQueryBuilderDsl>(p, DiscountedLineItemPriceQueryBuilderDsl.Of));
        }

    }
}
