using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomerSearches
{

    public partial class CustomerSearchIndexingStatusResponseQueryBuilderDsl
    {
        public CustomerSearchIndexingStatusResponseQueryBuilderDsl()
        {
        }

        public static CustomerSearchIndexingStatusResponseQueryBuilderDsl Of()
        {
            return new CustomerSearchIndexingStatusResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSearchIndexingStatusResponseQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<CustomerSearchIndexingStatusResponseQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<CustomerSearchIndexingStatusResponseQueryBuilderDsl>(p, CustomerSearchIndexingStatusResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerSearchIndexingStatusResponseQueryBuilderDsl> States(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerSearches.CustomerIndexingProgressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerSearches.CustomerIndexingProgressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerSearchIndexingStatusResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("states"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerSearches.CustomerIndexingProgressQueryBuilderDsl.Of())),
                CustomerSearchIndexingStatusResponseQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerSearchIndexingStatusResponseQueryBuilderDsl, DateTime> StartedAt()
        {
            return new ComparisonPredicateBuilder<CustomerSearchIndexingStatusResponseQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("startedAt")),
            p => new CombinationQueryPredicate<CustomerSearchIndexingStatusResponseQueryBuilderDsl>(p, CustomerSearchIndexingStatusResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSearchIndexingStatusResponseQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CustomerSearchIndexingStatusResponseQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CustomerSearchIndexingStatusResponseQueryBuilderDsl>(p, CustomerSearchIndexingStatusResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSearchIndexingStatusResponseQueryBuilderDsl, long> RetryCount()
        {
            return new ComparisonPredicateBuilder<CustomerSearchIndexingStatusResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("retryCount")),
            p => new CombinationQueryPredicate<CustomerSearchIndexingStatusResponseQueryBuilderDsl>(p, CustomerSearchIndexingStatusResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
