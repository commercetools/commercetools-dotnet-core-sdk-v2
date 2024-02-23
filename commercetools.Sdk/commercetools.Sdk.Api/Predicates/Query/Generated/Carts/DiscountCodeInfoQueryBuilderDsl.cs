using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class DiscountCodeInfoQueryBuilderDsl
    {
        public DiscountCodeInfoQueryBuilderDsl()
        {
        }

        public static DiscountCodeInfoQueryBuilderDsl Of()
        {
            return new DiscountCodeInfoQueryBuilderDsl();
        }

        public CombinationQueryPredicate<DiscountCodeInfoQueryBuilderDsl> DiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeInfoQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountCode"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl.Of())),
                DiscountCodeInfoQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DiscountCodeInfoQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<DiscountCodeInfoQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<DiscountCodeInfoQueryBuilderDsl>(p, DiscountCodeInfoQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
