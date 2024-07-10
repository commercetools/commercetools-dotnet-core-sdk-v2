using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeChangeCartDiscountsActionQueryBuilderDsl
    {
        public DiscountCodeChangeCartDiscountsActionQueryBuilderDsl()
        {
        }

        public static DiscountCodeChangeCartDiscountsActionQueryBuilderDsl Of()
        {
            return new DiscountCodeChangeCartDiscountsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeChangeCartDiscountsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountCodeChangeCartDiscountsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountCodeChangeCartDiscountsActionQueryBuilderDsl>(p, DiscountCodeChangeCartDiscountsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodeChangeCartDiscountsActionQueryBuilderDsl> CartDiscounts(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeChangeCartDiscountsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("cartDiscounts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountResourceIdentifierQueryBuilderDsl.Of())),
                DiscountCodeChangeCartDiscountsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DiscountCodeChangeCartDiscountsActionQueryBuilderDsl> CartDiscounts()
        {
            return new CollectionPredicateBuilder<DiscountCodeChangeCartDiscountsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartDiscounts")),
                    p => new CombinationQueryPredicate<DiscountCodeChangeCartDiscountsActionQueryBuilderDsl>(p, DiscountCodeChangeCartDiscountsActionQueryBuilderDsl.Of));
        }

    }
}
