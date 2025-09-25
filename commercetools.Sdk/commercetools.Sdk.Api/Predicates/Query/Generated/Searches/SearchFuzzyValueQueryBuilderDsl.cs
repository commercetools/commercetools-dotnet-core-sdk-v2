// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchFuzzyValueQueryBuilderDsl
    {
        public SearchFuzzyValueQueryBuilderDsl()
        {
        }

        public static SearchFuzzyValueQueryBuilderDsl Of()
        {
            return new SearchFuzzyValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchFuzzyValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<SearchFuzzyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<SearchFuzzyValueQueryBuilderDsl>(p, SearchFuzzyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFuzzyValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<SearchFuzzyValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<SearchFuzzyValueQueryBuilderDsl>(p, SearchFuzzyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFuzzyValueQueryBuilderDsl, string> FieldType()
        {
            return new ComparisonPredicateBuilder<SearchFuzzyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldType")),
            p => new CombinationQueryPredicate<SearchFuzzyValueQueryBuilderDsl>(p, SearchFuzzyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFuzzyValueQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<SearchFuzzyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<SearchFuzzyValueQueryBuilderDsl>(p, SearchFuzzyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFuzzyValueQueryBuilderDsl, long> Level()
        {
            return new ComparisonPredicateBuilder<SearchFuzzyValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("level")),
            p => new CombinationQueryPredicate<SearchFuzzyValueQueryBuilderDsl>(p, SearchFuzzyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFuzzyValueQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<SearchFuzzyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<SearchFuzzyValueQueryBuilderDsl>(p, SearchFuzzyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFuzzyValueQueryBuilderDsl, string> MustMatch()
        {
            return new ComparisonPredicateBuilder<SearchFuzzyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mustMatch")),
            p => new CombinationQueryPredicate<SearchFuzzyValueQueryBuilderDsl>(p, SearchFuzzyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
