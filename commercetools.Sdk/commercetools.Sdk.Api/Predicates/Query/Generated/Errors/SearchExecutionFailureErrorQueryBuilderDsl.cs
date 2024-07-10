using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class SearchExecutionFailureErrorQueryBuilderDsl
    {
        public SearchExecutionFailureErrorQueryBuilderDsl()
        {
        }

        public static SearchExecutionFailureErrorQueryBuilderDsl Of()
        {
            return new SearchExecutionFailureErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchExecutionFailureErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<SearchExecutionFailureErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<SearchExecutionFailureErrorQueryBuilderDsl>(p, SearchExecutionFailureErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchExecutionFailureErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<SearchExecutionFailureErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<SearchExecutionFailureErrorQueryBuilderDsl>(p, SearchExecutionFailureErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
