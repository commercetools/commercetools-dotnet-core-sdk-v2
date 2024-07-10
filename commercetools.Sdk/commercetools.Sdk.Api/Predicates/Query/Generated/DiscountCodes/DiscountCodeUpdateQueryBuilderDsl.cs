using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeUpdateQueryBuilderDsl
    {
        public DiscountCodeUpdateQueryBuilderDsl()
        {
        }

        public static DiscountCodeUpdateQueryBuilderDsl Of()
        {
            return new DiscountCodeUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<DiscountCodeUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<DiscountCodeUpdateQueryBuilderDsl>(p, DiscountCodeUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodeUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeUpdateActionQueryBuilderDsl.Of())),
                DiscountCodeUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DiscountCodeUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<DiscountCodeUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<DiscountCodeUpdateQueryBuilderDsl>(p, DiscountCodeUpdateQueryBuilderDsl.Of));
        }

    }
}
