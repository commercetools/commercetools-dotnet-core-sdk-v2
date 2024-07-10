using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderRemovePaymentActionQueryBuilderDsl
    {
        public OrderRemovePaymentActionQueryBuilderDsl()
        {
        }

        public static OrderRemovePaymentActionQueryBuilderDsl Of()
        {
            return new OrderRemovePaymentActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderRemovePaymentActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderRemovePaymentActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderRemovePaymentActionQueryBuilderDsl>(p, OrderRemovePaymentActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderRemovePaymentActionQueryBuilderDsl> Payment(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderRemovePaymentActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("payment"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentResourceIdentifierQueryBuilderDsl.Of())),
                OrderRemovePaymentActionQueryBuilderDsl.Of);
        }


    }
}
