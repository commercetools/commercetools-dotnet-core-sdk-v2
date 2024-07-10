using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchFullTextPrefixValueQueryBuilderDsl
    {
        public SearchFullTextPrefixValueQueryBuilderDsl()
        {
        }

        public static SearchFullTextPrefixValueQueryBuilderDsl Of()
        {
            return new SearchFullTextPrefixValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchFullTextPrefixValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<SearchFullTextPrefixValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<SearchFullTextPrefixValueQueryBuilderDsl>(p, SearchFullTextPrefixValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFullTextPrefixValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<SearchFullTextPrefixValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<SearchFullTextPrefixValueQueryBuilderDsl>(p, SearchFullTextPrefixValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFullTextPrefixValueQueryBuilderDsl, string> FieldType()
        {
            return new ComparisonPredicateBuilder<SearchFullTextPrefixValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldType")),
            p => new CombinationQueryPredicate<SearchFullTextPrefixValueQueryBuilderDsl>(p, SearchFullTextPrefixValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFullTextPrefixValueQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<SearchFullTextPrefixValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<SearchFullTextPrefixValueQueryBuilderDsl>(p, SearchFullTextPrefixValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFullTextPrefixValueQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<SearchFullTextPrefixValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<SearchFullTextPrefixValueQueryBuilderDsl>(p, SearchFullTextPrefixValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFullTextPrefixValueQueryBuilderDsl, string> MustMatch()
        {
            return new ComparisonPredicateBuilder<SearchFullTextPrefixValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mustMatch")),
            p => new CombinationQueryPredicate<SearchFullTextPrefixValueQueryBuilderDsl>(p, SearchFullTextPrefixValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
