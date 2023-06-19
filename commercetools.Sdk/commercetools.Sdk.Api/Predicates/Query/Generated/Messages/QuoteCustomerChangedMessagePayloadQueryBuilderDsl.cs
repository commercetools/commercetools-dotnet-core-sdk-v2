using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class QuoteCustomerChangedMessagePayloadQueryBuilderDsl
    {
        public QuoteCustomerChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static QuoteCustomerChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new QuoteCustomerChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteCustomerChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<QuoteCustomerChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<QuoteCustomerChangedMessagePayloadQueryBuilderDsl>(p, QuoteCustomerChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteCustomerChangedMessagePayloadQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteCustomerChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                QuoteCustomerChangedMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteCustomerChangedMessagePayloadQueryBuilderDsl> PreviousCustomer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteCustomerChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("previousCustomer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                QuoteCustomerChangedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
