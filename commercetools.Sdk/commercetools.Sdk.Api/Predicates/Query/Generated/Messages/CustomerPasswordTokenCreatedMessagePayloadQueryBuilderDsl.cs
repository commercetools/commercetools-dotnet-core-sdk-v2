using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl
    {
        public CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl>(p, CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl, string> CustomerId()
        {
            return new ComparisonPredicateBuilder<CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerId")),
            p => new CombinationQueryPredicate<CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl>(p, CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl, DateTime> ExpiresAt()
        {
            return new ComparisonPredicateBuilder<CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("expiresAt")),
            p => new CombinationQueryPredicate<CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl>(p, CustomerPasswordTokenCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
