using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchAnyValueQueryBuilderDsl
    {
        public SearchAnyValueQueryBuilderDsl()
        {
        }

        public static SearchAnyValueQueryBuilderDsl Of()
        {
            return new SearchAnyValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchAnyValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<SearchAnyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<SearchAnyValueQueryBuilderDsl>(p, SearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchAnyValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<SearchAnyValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<SearchAnyValueQueryBuilderDsl>(p, SearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchAnyValueQueryBuilderDsl, string> FieldType()
        {
            return new ComparisonPredicateBuilder<SearchAnyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldType")),
            p => new CombinationQueryPredicate<SearchAnyValueQueryBuilderDsl>(p, SearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchAnyValueQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<SearchAnyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<SearchAnyValueQueryBuilderDsl>(p, SearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchAnyValueQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<SearchAnyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<SearchAnyValueQueryBuilderDsl>(p, SearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchAnyValueQueryBuilderDsl, bool> CaseInsensitive()
        {
            return new ComparisonPredicateBuilder<SearchAnyValueQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("caseInsensitive")),
            p => new CombinationQueryPredicate<SearchAnyValueQueryBuilderDsl>(p, SearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
