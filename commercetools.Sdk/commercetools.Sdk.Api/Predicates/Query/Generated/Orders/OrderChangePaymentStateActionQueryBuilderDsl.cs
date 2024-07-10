using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderChangePaymentStateActionQueryBuilderDsl
    {
        public OrderChangePaymentStateActionQueryBuilderDsl()
        {
        }

        public static OrderChangePaymentStateActionQueryBuilderDsl Of()
        {
            return new OrderChangePaymentStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderChangePaymentStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderChangePaymentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderChangePaymentStateActionQueryBuilderDsl>(p, OrderChangePaymentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderChangePaymentStateActionQueryBuilderDsl, string> PaymentState()
        {
            return new ComparisonPredicateBuilder<OrderChangePaymentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentState")),
            p => new CombinationQueryPredicate<OrderChangePaymentStateActionQueryBuilderDsl>(p, OrderChangePaymentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
