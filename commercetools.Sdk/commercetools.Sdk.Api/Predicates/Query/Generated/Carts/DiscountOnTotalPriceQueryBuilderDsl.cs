using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class DiscountOnTotalPriceQueryBuilderDsl
    {
        public DiscountOnTotalPriceQueryBuilderDsl()
        {
        }

        public static DiscountOnTotalPriceQueryBuilderDsl Of()
        {
            return new DiscountOnTotalPriceQueryBuilderDsl();
        }

        public CombinationQueryPredicate<DiscountOnTotalPriceQueryBuilderDsl> DiscountedAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountOnTotalPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountedAmount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl.Of())),
                DiscountOnTotalPriceQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountOnTotalPriceQueryBuilderDsl> IncludedDiscounts(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedTotalPricePortionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedTotalPricePortionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountOnTotalPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("includedDiscounts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedTotalPricePortionQueryBuilderDsl.Of())),
                DiscountOnTotalPriceQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DiscountOnTotalPriceQueryBuilderDsl> IncludedDiscounts()
        {
            return new CollectionPredicateBuilder<DiscountOnTotalPriceQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("includedDiscounts")),
                    p => new CombinationQueryPredicate<DiscountOnTotalPriceQueryBuilderDsl>(p, DiscountOnTotalPriceQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<DiscountOnTotalPriceQueryBuilderDsl> DiscountedNetAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountOnTotalPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountedNetAmount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl.Of())),
                DiscountOnTotalPriceQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountOnTotalPriceQueryBuilderDsl> DiscountedGrossAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountOnTotalPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountedGrossAmount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl.Of())),
                DiscountOnTotalPriceQueryBuilderDsl.Of);
        }


    }
}
