using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl
    {
        public CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl()
        {
        }

        public static CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl Of()
        {
            return new CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl, string> ProjectKey()
        {
            return new ComparisonPredicateBuilder<CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("projectKey")),
            p => new CombinationQueryPredicate<CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl>(p, CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl> Payment(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("payment"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl.Of())),
                CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl, string> TransactionId()
        {
            return new ComparisonPredicateBuilder<CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transactionId")),
            p => new CombinationQueryPredicate<CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl>(p, CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl> Cart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("cart"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl.Of())),
                CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl> Order(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("order"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl.Of())),
                CheckoutMessagePaymentsPayloadBaseDataQueryBuilderDsl.Of);
        }


    }
}
