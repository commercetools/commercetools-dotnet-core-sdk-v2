using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class MaxStoreReferencesReachedErrorQueryBuilderDsl
    {
        public MaxStoreReferencesReachedErrorQueryBuilderDsl()
        {
        }

        public static MaxStoreReferencesReachedErrorQueryBuilderDsl Of()
        {
            return new MaxStoreReferencesReachedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MaxStoreReferencesReachedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<MaxStoreReferencesReachedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<MaxStoreReferencesReachedErrorQueryBuilderDsl>(p, MaxStoreReferencesReachedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MaxStoreReferencesReachedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<MaxStoreReferencesReachedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<MaxStoreReferencesReachedErrorQueryBuilderDsl>(p, MaxStoreReferencesReachedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
