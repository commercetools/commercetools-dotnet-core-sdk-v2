using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountTotalPriceTargetQueryBuilderDsl
    {
        public CartDiscountTotalPriceTargetQueryBuilderDsl()
        {
        }

        public static CartDiscountTotalPriceTargetQueryBuilderDsl Of()
        {
            return new CartDiscountTotalPriceTargetQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountTotalPriceTargetQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountTotalPriceTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountTotalPriceTargetQueryBuilderDsl>(p, CartDiscountTotalPriceTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
