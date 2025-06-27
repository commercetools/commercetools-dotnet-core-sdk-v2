using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountGroups
{

    public partial class DiscountGroupUpdateQueryBuilderDsl
    {
        public DiscountGroupUpdateQueryBuilderDsl()
        {
        }

        public static DiscountGroupUpdateQueryBuilderDsl Of()
        {
            return new DiscountGroupUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<DiscountGroupUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<DiscountGroupUpdateQueryBuilderDsl>(p, DiscountGroupUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountGroupUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupUpdateActionQueryBuilderDsl.Of())),
                DiscountGroupUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DiscountGroupUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<DiscountGroupUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<DiscountGroupUpdateQueryBuilderDsl>(p, DiscountGroupUpdateQueryBuilderDsl.Of));
        }

    }
}
