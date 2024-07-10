using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchExistsValueQueryBuilderDsl
    {
        public SearchExistsValueQueryBuilderDsl()
        {
        }

        public static SearchExistsValueQueryBuilderDsl Of()
        {
            return new SearchExistsValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchExistsValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<SearchExistsValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<SearchExistsValueQueryBuilderDsl>(p, SearchExistsValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchExistsValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<SearchExistsValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<SearchExistsValueQueryBuilderDsl>(p, SearchExistsValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchExistsValueQueryBuilderDsl, string> FieldType()
        {
            return new ComparisonPredicateBuilder<SearchExistsValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldType")),
            p => new CombinationQueryPredicate<SearchExistsValueQueryBuilderDsl>(p, SearchExistsValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchExistsValueQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<SearchExistsValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<SearchExistsValueQueryBuilderDsl>(p, SearchExistsValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
