using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class DirectDiscountQueryBuilderDsl
    {
        public DirectDiscountQueryBuilderDsl()
        {
        }

        public static DirectDiscountQueryBuilderDsl Of()
        {
            return new DirectDiscountQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DirectDiscountQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<DirectDiscountQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<DirectDiscountQueryBuilderDsl>(p, DirectDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DirectDiscountQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DirectDiscountQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueQueryBuilderDsl.Of())),
                DirectDiscountQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DirectDiscountQueryBuilderDsl> Target(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DirectDiscountQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("target"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTargetQueryBuilderDsl.Of())),
                DirectDiscountQueryBuilderDsl.Of);
        }


    }
}
