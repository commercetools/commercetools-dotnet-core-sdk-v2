using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class AbsoluteAllocationQueryBuilderDsl
    {
        public AbsoluteAllocationQueryBuilderDsl()
        {
        }

        public static AbsoluteAllocationQueryBuilderDsl Of()
        {
            return new AbsoluteAllocationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AbsoluteAllocationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AbsoluteAllocationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AbsoluteAllocationQueryBuilderDsl>(p, AbsoluteAllocationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AbsoluteAllocationQueryBuilderDsl> Amount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.HighPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.HighPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AbsoluteAllocationQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("amount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.HighPrecisionMoneyQueryBuilderDsl.Of())),
                AbsoluteAllocationQueryBuilderDsl.Of);
        }


    }
}
