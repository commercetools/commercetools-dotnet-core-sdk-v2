using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class AllocationDraftQueryBuilderDsl
    {
        public AllocationDraftQueryBuilderDsl()
        {
        }

        public static AllocationDraftQueryBuilderDsl Of()
        {
            return new AllocationDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AllocationDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AllocationDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AllocationDraftQueryBuilderDsl>(p, AllocationDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<AllocationDraftQueryBuilderDsl> AsAbsolute(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.AbsoluteAllocationDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.AbsoluteAllocationDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AllocationDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.AbsoluteAllocationDraftQueryBuilderDsl.Of()),
                AllocationDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AllocationDraftQueryBuilderDsl> AsRelative(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.RelativeAllocationDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.RelativeAllocationDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AllocationDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.RelativeAllocationDraftQueryBuilderDsl.Of()),
                AllocationDraftQueryBuilderDsl.Of);
        }
    }
}
