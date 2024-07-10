using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class DuplicatePriceScopeErrorQueryBuilderDsl
    {
        public DuplicatePriceScopeErrorQueryBuilderDsl()
        {
        }

        public static DuplicatePriceScopeErrorQueryBuilderDsl Of()
        {
            return new DuplicatePriceScopeErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DuplicatePriceScopeErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<DuplicatePriceScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<DuplicatePriceScopeErrorQueryBuilderDsl>(p, DuplicatePriceScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DuplicatePriceScopeErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<DuplicatePriceScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<DuplicatePriceScopeErrorQueryBuilderDsl>(p, DuplicatePriceScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DuplicatePriceScopeErrorQueryBuilderDsl> ConflictingPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DuplicatePriceScopeErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("conflictingPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl.Of())),
                DuplicatePriceScopeErrorQueryBuilderDsl.Of);
        }


    }
}
