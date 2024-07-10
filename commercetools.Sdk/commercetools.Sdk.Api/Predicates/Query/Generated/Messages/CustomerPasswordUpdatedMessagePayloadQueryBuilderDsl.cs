using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerPasswordUpdatedMessagePayloadQueryBuilderDsl
    {
        public CustomerPasswordUpdatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerPasswordUpdatedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerPasswordUpdatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerPasswordUpdatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerPasswordUpdatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerPasswordUpdatedMessagePayloadQueryBuilderDsl>(p, CustomerPasswordUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerPasswordUpdatedMessagePayloadQueryBuilderDsl, bool> Reset()
        {
            return new ComparisonPredicateBuilder<CustomerPasswordUpdatedMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reset")),
            p => new CombinationQueryPredicate<CustomerPasswordUpdatedMessagePayloadQueryBuilderDsl>(p, CustomerPasswordUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
