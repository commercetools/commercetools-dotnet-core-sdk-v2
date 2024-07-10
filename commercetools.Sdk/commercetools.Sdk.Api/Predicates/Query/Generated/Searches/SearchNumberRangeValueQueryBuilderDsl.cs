using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchNumberRangeValueQueryBuilderDsl
    {
        public SearchNumberRangeValueQueryBuilderDsl()
        {
        }

        public static SearchNumberRangeValueQueryBuilderDsl Of()
        {
            return new SearchNumberRangeValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchNumberRangeValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<SearchNumberRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<SearchNumberRangeValueQueryBuilderDsl>(p, SearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchNumberRangeValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<SearchNumberRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<SearchNumberRangeValueQueryBuilderDsl>(p, SearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchNumberRangeValueQueryBuilderDsl, string> FieldType()
        {
            return new ComparisonPredicateBuilder<SearchNumberRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldType")),
            p => new CombinationQueryPredicate<SearchNumberRangeValueQueryBuilderDsl>(p, SearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchNumberRangeValueQueryBuilderDsl, decimal> Gte()
        {
            return new ComparisonPredicateBuilder<SearchNumberRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gte")),
            p => new CombinationQueryPredicate<SearchNumberRangeValueQueryBuilderDsl>(p, SearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchNumberRangeValueQueryBuilderDsl, decimal> Gt()
        {
            return new ComparisonPredicateBuilder<SearchNumberRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gt")),
            p => new CombinationQueryPredicate<SearchNumberRangeValueQueryBuilderDsl>(p, SearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchNumberRangeValueQueryBuilderDsl, decimal> Lte()
        {
            return new ComparisonPredicateBuilder<SearchNumberRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lte")),
            p => new CombinationQueryPredicate<SearchNumberRangeValueQueryBuilderDsl>(p, SearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchNumberRangeValueQueryBuilderDsl, decimal> Lt()
        {
            return new ComparisonPredicateBuilder<SearchNumberRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lt")),
            p => new CombinationQueryPredicate<SearchNumberRangeValueQueryBuilderDsl>(p, SearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
