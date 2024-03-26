using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchDateTimeRangeValueQueryBuilderDsl
    {
        public SearchDateTimeRangeValueQueryBuilderDsl()
        {
        }

        public static SearchDateTimeRangeValueQueryBuilderDsl Of()
        {
            return new SearchDateTimeRangeValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchDateTimeRangeValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<SearchDateTimeRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<SearchDateTimeRangeValueQueryBuilderDsl>(p, SearchDateTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchDateTimeRangeValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<SearchDateTimeRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<SearchDateTimeRangeValueQueryBuilderDsl>(p, SearchDateTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchDateTimeRangeValueQueryBuilderDsl, string> FieldType()
        {
            return new ComparisonPredicateBuilder<SearchDateTimeRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldType")),
            p => new CombinationQueryPredicate<SearchDateTimeRangeValueQueryBuilderDsl>(p, SearchDateTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchDateTimeRangeValueQueryBuilderDsl, DateTime> Gte()
        {
            return new ComparisonPredicateBuilder<SearchDateTimeRangeValueQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gte")),
            p => new CombinationQueryPredicate<SearchDateTimeRangeValueQueryBuilderDsl>(p, SearchDateTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchDateTimeRangeValueQueryBuilderDsl, DateTime> Gt()
        {
            return new ComparisonPredicateBuilder<SearchDateTimeRangeValueQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gt")),
            p => new CombinationQueryPredicate<SearchDateTimeRangeValueQueryBuilderDsl>(p, SearchDateTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchDateTimeRangeValueQueryBuilderDsl, DateTime> Lte()
        {
            return new ComparisonPredicateBuilder<SearchDateTimeRangeValueQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lte")),
            p => new CombinationQueryPredicate<SearchDateTimeRangeValueQueryBuilderDsl>(p, SearchDateTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchDateTimeRangeValueQueryBuilderDsl, DateTime> Lt()
        {
            return new ComparisonPredicateBuilder<SearchDateTimeRangeValueQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lt")),
            p => new CombinationQueryPredicate<SearchDateTimeRangeValueQueryBuilderDsl>(p, SearchDateTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
