using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderAddPaymentActionQueryBuilderDsl
    {
        public OrderAddPaymentActionQueryBuilderDsl()
        {
        }

        public static OrderAddPaymentActionQueryBuilderDsl Of()
        {
            return new OrderAddPaymentActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderAddPaymentActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderAddPaymentActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderAddPaymentActionQueryBuilderDsl>(p, OrderAddPaymentActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderAddPaymentActionQueryBuilderDsl> Payment(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderAddPaymentActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("payment"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl.Of())),
                OrderAddPaymentActionQueryBuilderDsl.Of);
        }


    }
}
