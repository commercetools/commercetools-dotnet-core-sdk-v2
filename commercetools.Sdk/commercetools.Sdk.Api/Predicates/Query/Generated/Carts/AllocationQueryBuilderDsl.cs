using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class AllocationQueryBuilderDsl
    {
        public AllocationQueryBuilderDsl()
        {
        }

        public static AllocationQueryBuilderDsl Of()
        {
            return new AllocationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AllocationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AllocationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AllocationQueryBuilderDsl>(p, AllocationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<AllocationQueryBuilderDsl> AsAbsolute(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.AbsoluteAllocationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.AbsoluteAllocationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AllocationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.AbsoluteAllocationQueryBuilderDsl.Of()),
                AllocationQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AllocationQueryBuilderDsl> AsRelative(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.RelativeAllocationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.RelativeAllocationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AllocationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.RelativeAllocationQueryBuilderDsl.Of()),
                AllocationQueryBuilderDsl.Of);
        }
    }
}
