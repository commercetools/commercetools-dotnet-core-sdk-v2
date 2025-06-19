using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchSortingQueryBuilderDsl
    {
        public SearchSortingQueryBuilderDsl()
        {
        }

        public static SearchSortingQueryBuilderDsl Of()
        {
            return new SearchSortingQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchSortingQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<SearchSortingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<SearchSortingQueryBuilderDsl>(p, SearchSortingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchSortingQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<SearchSortingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<SearchSortingQueryBuilderDsl>(p, SearchSortingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchSortingQueryBuilderDsl, string> Order()
        {
            return new ComparisonPredicateBuilder<SearchSortingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("order")),
            p => new CombinationQueryPredicate<SearchSortingQueryBuilderDsl>(p, SearchSortingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchSortingQueryBuilderDsl, string> Mode()
        {
            return new ComparisonPredicateBuilder<SearchSortingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mode")),
            p => new CombinationQueryPredicate<SearchSortingQueryBuilderDsl>(p, SearchSortingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchSortingQueryBuilderDsl, string> FieldType()
        {
            return new ComparisonPredicateBuilder<SearchSortingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldType")),
            p => new CombinationQueryPredicate<SearchSortingQueryBuilderDsl>(p, SearchSortingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<SearchSortingQueryBuilderDsl> Filter(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchSortingQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("filter"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl.Of())),
                SearchSortingQueryBuilderDsl.Of);
        }


    }
}
