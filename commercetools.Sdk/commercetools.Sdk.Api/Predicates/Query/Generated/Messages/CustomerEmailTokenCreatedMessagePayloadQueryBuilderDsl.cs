using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl
    {
        public CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl>(p, CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl, string> CustomerId()
        {
            return new ComparisonPredicateBuilder<CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerId")),
            p => new CombinationQueryPredicate<CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl>(p, CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl, DateTime> ExpiresAt()
        {
            return new ComparisonPredicateBuilder<CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("expiresAt")),
            p => new CombinationQueryPredicate<CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl>(p, CustomerEmailTokenCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
