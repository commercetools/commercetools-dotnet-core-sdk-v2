using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class SearchIndexingInProgressErrorQueryBuilderDsl
    {
        public SearchIndexingInProgressErrorQueryBuilderDsl()
        {
        }

        public static SearchIndexingInProgressErrorQueryBuilderDsl Of()
        {
            return new SearchIndexingInProgressErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchIndexingInProgressErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<SearchIndexingInProgressErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<SearchIndexingInProgressErrorQueryBuilderDsl>(p, SearchIndexingInProgressErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchIndexingInProgressErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<SearchIndexingInProgressErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<SearchIndexingInProgressErrorQueryBuilderDsl>(p, SearchIndexingInProgressErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
