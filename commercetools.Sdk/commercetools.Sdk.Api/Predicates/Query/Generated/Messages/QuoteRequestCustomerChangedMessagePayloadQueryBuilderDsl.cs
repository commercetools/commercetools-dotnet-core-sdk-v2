using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl
    {
        public QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl>(p, QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl> PreviousCustomer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("previousCustomer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                QuoteRequestCustomerChangedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
