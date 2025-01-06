using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnitSearches
{

    public partial class BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl
    {
        public BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl()
        {
        }

        public static BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl Of()
        {
            return new BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl>(p, BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl> States(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnitSearches.BusinessUnitIndexingProgressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnitSearches.BusinessUnitIndexingProgressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("states"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnitSearches.BusinessUnitIndexingProgressQueryBuilderDsl.Of())),
                BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl, DateTime> StartedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("startedAt")),
            p => new CombinationQueryPredicate<BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl>(p, BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl>(p, BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl, long> RetryCount()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("retryCount")),
            p => new CombinationQueryPredicate<BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl>(p, BusinessUnitSearchIndexingStatusResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
