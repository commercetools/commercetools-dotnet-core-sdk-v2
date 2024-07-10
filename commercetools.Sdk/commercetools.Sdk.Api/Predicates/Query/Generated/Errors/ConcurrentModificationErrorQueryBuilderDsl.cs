using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ConcurrentModificationErrorQueryBuilderDsl
    {
        public ConcurrentModificationErrorQueryBuilderDsl()
        {
        }

        public static ConcurrentModificationErrorQueryBuilderDsl Of()
        {
            return new ConcurrentModificationErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ConcurrentModificationErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ConcurrentModificationErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ConcurrentModificationErrorQueryBuilderDsl>(p, ConcurrentModificationErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ConcurrentModificationErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ConcurrentModificationErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ConcurrentModificationErrorQueryBuilderDsl>(p, ConcurrentModificationErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ConcurrentModificationErrorQueryBuilderDsl, long> CurrentVersion()
        {
            return new ComparisonPredicateBuilder<ConcurrentModificationErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currentVersion")),
            p => new CombinationQueryPredicate<ConcurrentModificationErrorQueryBuilderDsl>(p, ConcurrentModificationErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
