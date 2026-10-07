using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class AbsoluteAllocationDraftQueryBuilderDsl
    {
        public AbsoluteAllocationDraftQueryBuilderDsl()
        {
        }

        public static AbsoluteAllocationDraftQueryBuilderDsl Of()
        {
            return new AbsoluteAllocationDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AbsoluteAllocationDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AbsoluteAllocationDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AbsoluteAllocationDraftQueryBuilderDsl>(p, AbsoluteAllocationDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AbsoluteAllocationDraftQueryBuilderDsl> Amount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.HighPrecisionMoneyDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.HighPrecisionMoneyDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AbsoluteAllocationDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("amount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.HighPrecisionMoneyDraftQueryBuilderDsl.Of())),
                AbsoluteAllocationDraftQueryBuilderDsl.Of);
        }


    }
}
