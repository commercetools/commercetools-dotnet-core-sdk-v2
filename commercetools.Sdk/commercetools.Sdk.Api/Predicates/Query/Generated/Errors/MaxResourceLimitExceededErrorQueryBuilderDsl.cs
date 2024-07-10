using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class MaxResourceLimitExceededErrorQueryBuilderDsl
    {
        public MaxResourceLimitExceededErrorQueryBuilderDsl()
        {
        }

        public static MaxResourceLimitExceededErrorQueryBuilderDsl Of()
        {
            return new MaxResourceLimitExceededErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MaxResourceLimitExceededErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<MaxResourceLimitExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<MaxResourceLimitExceededErrorQueryBuilderDsl>(p, MaxResourceLimitExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MaxResourceLimitExceededErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<MaxResourceLimitExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<MaxResourceLimitExceededErrorQueryBuilderDsl>(p, MaxResourceLimitExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MaxResourceLimitExceededErrorQueryBuilderDsl, string> ExceededResource()
        {
            return new ComparisonPredicateBuilder<MaxResourceLimitExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("exceededResource")),
            p => new CombinationQueryPredicate<MaxResourceLimitExceededErrorQueryBuilderDsl>(p, MaxResourceLimitExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
