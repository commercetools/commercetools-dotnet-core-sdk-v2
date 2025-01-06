// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchExactValueQueryBuilderDsl
    {
        public SearchExactValueQueryBuilderDsl()
        {
        }

        public static SearchExactValueQueryBuilderDsl Of()
        {
            return new SearchExactValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchExactValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<SearchExactValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<SearchExactValueQueryBuilderDsl>(p, SearchExactValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchExactValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<SearchExactValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<SearchExactValueQueryBuilderDsl>(p, SearchExactValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchExactValueQueryBuilderDsl, string> FieldType()
        {
            return new ComparisonPredicateBuilder<SearchExactValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldType")),
            p => new CombinationQueryPredicate<SearchExactValueQueryBuilderDsl>(p, SearchExactValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchExactValueQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<SearchExactValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<SearchExactValueQueryBuilderDsl>(p, SearchExactValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchExactValueQueryBuilderDsl, string> Values()
        {
            return new ComparisonPredicateBuilder<SearchExactValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("values")),
            p => new CombinationQueryPredicate<SearchExactValueQueryBuilderDsl>(p, SearchExactValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchExactValueQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<SearchExactValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<SearchExactValueQueryBuilderDsl>(p, SearchExactValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchExactValueQueryBuilderDsl, bool> CaseInsensitive()
        {
            return new ComparisonPredicateBuilder<SearchExactValueQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("caseInsensitive")),
            p => new CombinationQueryPredicate<SearchExactValueQueryBuilderDsl>(p, SearchExactValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
