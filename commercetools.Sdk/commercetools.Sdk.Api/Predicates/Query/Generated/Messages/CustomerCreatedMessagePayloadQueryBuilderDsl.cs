using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerCreatedMessagePayloadQueryBuilderDsl
    {
        public CustomerCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerCreatedMessagePayloadQueryBuilderDsl>(p, CustomerCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerCreatedMessagePayloadQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerQueryBuilderDsl.Of())),
                CustomerCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
