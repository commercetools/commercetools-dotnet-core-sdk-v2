using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchLongRangeValueQueryBuilderDsl
    {
        public SearchLongRangeValueQueryBuilderDsl()
        {
        }

        public static SearchLongRangeValueQueryBuilderDsl Of()
        {
            return new SearchLongRangeValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchLongRangeValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<SearchLongRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<SearchLongRangeValueQueryBuilderDsl>(p, SearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchLongRangeValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<SearchLongRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<SearchLongRangeValueQueryBuilderDsl>(p, SearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchLongRangeValueQueryBuilderDsl, string> FieldType()
        {
            return new ComparisonPredicateBuilder<SearchLongRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldType")),
            p => new CombinationQueryPredicate<SearchLongRangeValueQueryBuilderDsl>(p, SearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchLongRangeValueQueryBuilderDsl, long> Gte()
        {
            return new ComparisonPredicateBuilder<SearchLongRangeValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gte")),
            p => new CombinationQueryPredicate<SearchLongRangeValueQueryBuilderDsl>(p, SearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchLongRangeValueQueryBuilderDsl, long> Gt()
        {
            return new ComparisonPredicateBuilder<SearchLongRangeValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gt")),
            p => new CombinationQueryPredicate<SearchLongRangeValueQueryBuilderDsl>(p, SearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchLongRangeValueQueryBuilderDsl, long> Lte()
        {
            return new ComparisonPredicateBuilder<SearchLongRangeValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lte")),
            p => new CombinationQueryPredicate<SearchLongRangeValueQueryBuilderDsl>(p, SearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchLongRangeValueQueryBuilderDsl, long> Lt()
        {
            return new ComparisonPredicateBuilder<SearchLongRangeValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lt")),
            p => new CombinationQueryPredicate<SearchLongRangeValueQueryBuilderDsl>(p, SearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
