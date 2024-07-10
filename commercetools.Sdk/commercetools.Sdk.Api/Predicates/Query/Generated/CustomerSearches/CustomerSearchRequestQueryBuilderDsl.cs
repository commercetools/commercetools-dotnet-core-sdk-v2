using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomerSearches
{

    public partial class CustomerSearchRequestQueryBuilderDsl
    {
        public CustomerSearchRequestQueryBuilderDsl()
        {
        }

        public static CustomerSearchRequestQueryBuilderDsl Of()
        {
            return new CustomerSearchRequestQueryBuilderDsl();
        }

        public CombinationQueryPredicate<CustomerSearchRequestQueryBuilderDsl> Query(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerSearchRequestQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("query"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchQueryQueryBuilderDsl.Of())),
                CustomerSearchRequestQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomerSearchRequestQueryBuilderDsl> Sort(
            Func<commercetools.Sdk.Api.Predicates.Query.Searches.SearchSortingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Searches.SearchSortingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerSearchRequestQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("sort"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Searches.SearchSortingQueryBuilderDsl.Of())),
                CustomerSearchRequestQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomerSearchRequestQueryBuilderDsl> Sort()
        {
            return new CollectionPredicateBuilder<CustomerSearchRequestQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sort")),
                    p => new CombinationQueryPredicate<CustomerSearchRequestQueryBuilderDsl>(p, CustomerSearchRequestQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<CustomerSearchRequestQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<CustomerSearchRequestQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<CustomerSearchRequestQueryBuilderDsl>(p, CustomerSearchRequestQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSearchRequestQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<CustomerSearchRequestQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<CustomerSearchRequestQueryBuilderDsl>(p, CustomerSearchRequestQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
