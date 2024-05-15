// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchFullTextValueQueryBuilderDsl
    {
        public SearchFullTextValueQueryBuilderDsl()
        {
        }

        public static SearchFullTextValueQueryBuilderDsl Of()
        {
            return new SearchFullTextValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchFullTextValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<SearchFullTextValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<SearchFullTextValueQueryBuilderDsl>(p, SearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFullTextValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<SearchFullTextValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<SearchFullTextValueQueryBuilderDsl>(p, SearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFullTextValueQueryBuilderDsl, string> FieldType()
        {
            return new ComparisonPredicateBuilder<SearchFullTextValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldType")),
            p => new CombinationQueryPredicate<SearchFullTextValueQueryBuilderDsl>(p, SearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFullTextValueQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<SearchFullTextValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<SearchFullTextValueQueryBuilderDsl>(p, SearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFullTextValueQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<SearchFullTextValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<SearchFullTextValueQueryBuilderDsl>(p, SearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFullTextValueQueryBuilderDsl, string> MustMatch()
        {
            return new ComparisonPredicateBuilder<SearchFullTextValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mustMatch")),
            p => new CombinationQueryPredicate<SearchFullTextValueQueryBuilderDsl>(p, SearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
