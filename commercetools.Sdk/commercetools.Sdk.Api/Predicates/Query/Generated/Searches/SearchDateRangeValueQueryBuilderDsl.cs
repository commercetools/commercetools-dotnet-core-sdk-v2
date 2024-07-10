using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchDateRangeValueQueryBuilderDsl
    {
        public SearchDateRangeValueQueryBuilderDsl()
        {
        }

        public static SearchDateRangeValueQueryBuilderDsl Of()
        {
            return new SearchDateRangeValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchDateRangeValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<SearchDateRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<SearchDateRangeValueQueryBuilderDsl>(p, SearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchDateRangeValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<SearchDateRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<SearchDateRangeValueQueryBuilderDsl>(p, SearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchDateRangeValueQueryBuilderDsl, string> FieldType()
        {
            return new ComparisonPredicateBuilder<SearchDateRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldType")),
            p => new CombinationQueryPredicate<SearchDateRangeValueQueryBuilderDsl>(p, SearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchDateRangeValueQueryBuilderDsl, Date> Gte()
        {
            return new ComparisonPredicateBuilder<SearchDateRangeValueQueryBuilderDsl, Date>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gte")),
            p => new CombinationQueryPredicate<SearchDateRangeValueQueryBuilderDsl>(p, SearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchDateRangeValueQueryBuilderDsl, Date> Gt()
        {
            return new ComparisonPredicateBuilder<SearchDateRangeValueQueryBuilderDsl, Date>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gt")),
            p => new CombinationQueryPredicate<SearchDateRangeValueQueryBuilderDsl>(p, SearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchDateRangeValueQueryBuilderDsl, Date> Lte()
        {
            return new ComparisonPredicateBuilder<SearchDateRangeValueQueryBuilderDsl, Date>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lte")),
            p => new CombinationQueryPredicate<SearchDateRangeValueQueryBuilderDsl>(p, SearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchDateRangeValueQueryBuilderDsl, Date> Lt()
        {
            return new ComparisonPredicateBuilder<SearchDateRangeValueQueryBuilderDsl, Date>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lt")),
            p => new CombinationQueryPredicate<SearchDateRangeValueQueryBuilderDsl>(p, SearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
