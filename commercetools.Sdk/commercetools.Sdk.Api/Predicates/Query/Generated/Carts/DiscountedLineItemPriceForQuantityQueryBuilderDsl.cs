using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class DiscountedLineItemPriceForQuantityQueryBuilderDsl
    {
        public DiscountedLineItemPriceForQuantityQueryBuilderDsl()
        {
        }

        public static DiscountedLineItemPriceForQuantityQueryBuilderDsl Of()
        {
            return new DiscountedLineItemPriceForQuantityQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountedLineItemPriceForQuantityQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<DiscountedLineItemPriceForQuantityQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<DiscountedLineItemPriceForQuantityQueryBuilderDsl>(p, DiscountedLineItemPriceForQuantityQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountedLineItemPriceForQuantityQueryBuilderDsl> DiscountedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountedLineItemPriceForQuantityQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceQueryBuilderDsl.Of())),
                DiscountedLineItemPriceForQuantityQueryBuilderDsl.Of);
        }


    }
}
