using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomerSearches
{

    public partial class CustomerPagedSearchResponseQueryBuilderDsl
    {
        public CustomerPagedSearchResponseQueryBuilderDsl()
        {
        }

        public static CustomerPagedSearchResponseQueryBuilderDsl Of()
        {
            return new CustomerPagedSearchResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerPagedSearchResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<CustomerPagedSearchResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<CustomerPagedSearchResponseQueryBuilderDsl>(p, CustomerPagedSearchResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerPagedSearchResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<CustomerPagedSearchResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<CustomerPagedSearchResponseQueryBuilderDsl>(p, CustomerPagedSearchResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerPagedSearchResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<CustomerPagedSearchResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<CustomerPagedSearchResponseQueryBuilderDsl>(p, CustomerPagedSearchResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerPagedSearchResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerSearches.CustomerSearchResultQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerSearches.CustomerSearchResultQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerPagedSearchResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerSearches.CustomerSearchResultQueryBuilderDsl.Of())),
                CustomerPagedSearchResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomerPagedSearchResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<CustomerPagedSearchResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<CustomerPagedSearchResponseQueryBuilderDsl>(p, CustomerPagedSearchResponseQueryBuilderDsl.Of));
        }

    }
}
