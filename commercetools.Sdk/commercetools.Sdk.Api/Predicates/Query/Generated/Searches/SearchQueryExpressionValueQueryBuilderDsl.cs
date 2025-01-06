using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchQueryExpressionValueQueryBuilderDsl
    {
        public SearchQueryExpressionValueQueryBuilderDsl()
        {
        }

        public static SearchQueryExpressionValueQueryBuilderDsl Of()
        {
            return new SearchQueryExpressionValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchQueryExpressionValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<SearchQueryExpressionValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl>(p, SearchQueryExpressionValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchQueryExpressionValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<SearchQueryExpressionValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl>(p, SearchQueryExpressionValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchQueryExpressionValueQueryBuilderDsl, string> FieldType()
        {
            return new ComparisonPredicateBuilder<SearchQueryExpressionValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldType")),
            p => new CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl>(p, SearchQueryExpressionValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl> AsSearchAnyValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchAnyValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchAnyValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchAnyValueQueryBuilderDsl.Of()),
                SearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl> AsSearchDateRangeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateRangeValueQueryBuilderDsl.Of()),
                SearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl> AsSearchDateTimeRangeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateTimeRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateTimeRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchDateTimeRangeValueQueryBuilderDsl.Of()),
                SearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl> AsSearchExactValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchExactValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchExactValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchExactValueQueryBuilderDsl.Of()),
                SearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl> AsSearchExistsValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchExistsValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchExistsValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchExistsValueQueryBuilderDsl.Of()),
                SearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl> AsSearchFullTextPrefixValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextPrefixValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextPrefixValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextPrefixValueQueryBuilderDsl.Of()),
                SearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl> AsSearchFullTextValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchFullTextValueQueryBuilderDsl.Of()),
                SearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl> AsSearchLongRangeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchLongRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchLongRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchLongRangeValueQueryBuilderDsl.Of()),
                SearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl> AsSearchNumberRangeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchNumberRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchNumberRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchNumberRangeValueQueryBuilderDsl.Of()),
                SearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl> AsSearchTimeRangeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchTimeRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchTimeRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchTimeRangeValueQueryBuilderDsl.Of()),
                SearchQueryExpressionValueQueryBuilderDsl.Of);
        }
    }
}
