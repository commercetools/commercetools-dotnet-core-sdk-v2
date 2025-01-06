using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnitSearches
{

    public partial class BusinessUnitSearchRequestQueryBuilderDsl
    {
        public BusinessUnitSearchRequestQueryBuilderDsl()
        {
        }

        public static BusinessUnitSearchRequestQueryBuilderDsl Of()
        {
            return new BusinessUnitSearchRequestQueryBuilderDsl();
        }

        public CombinationQueryPredicate<BusinessUnitSearchRequestQueryBuilderDsl> Query(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitSearchRequestQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("query"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl.Of())),
                BusinessUnitSearchRequestQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitSearchRequestQueryBuilderDsl> Sort(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchSortingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchSortingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitSearchRequestQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("sort"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchSortingQueryBuilderDsl.Of())),
                BusinessUnitSearchRequestQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitSearchRequestQueryBuilderDsl> Sort()
        {
            return new CollectionPredicateBuilder<BusinessUnitSearchRequestQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sort")),
                    p => new CombinationQueryPredicate<BusinessUnitSearchRequestQueryBuilderDsl>(p, BusinessUnitSearchRequestQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<BusinessUnitSearchRequestQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSearchRequestQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<BusinessUnitSearchRequestQueryBuilderDsl>(p, BusinessUnitSearchRequestQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitSearchRequestQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSearchRequestQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<BusinessUnitSearchRequestQueryBuilderDsl>(p, BusinessUnitSearchRequestQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
