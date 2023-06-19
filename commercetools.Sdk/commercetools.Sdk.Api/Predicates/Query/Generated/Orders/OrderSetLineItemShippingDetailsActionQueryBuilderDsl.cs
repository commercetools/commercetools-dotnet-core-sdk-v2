using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetLineItemShippingDetailsActionQueryBuilderDsl
    {
        public OrderSetLineItemShippingDetailsActionQueryBuilderDsl()
        {
        }

        public static OrderSetLineItemShippingDetailsActionQueryBuilderDsl Of()
        {
            return new OrderSetLineItemShippingDetailsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetLineItemShippingDetailsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetLineItemShippingDetailsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetLineItemShippingDetailsActionQueryBuilderDsl>(p, OrderSetLineItemShippingDetailsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetLineItemShippingDetailsActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<OrderSetLineItemShippingDetailsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<OrderSetLineItemShippingDetailsActionQueryBuilderDsl>(p, OrderSetLineItemShippingDetailsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetLineItemShippingDetailsActionQueryBuilderDsl> ShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetLineItemShippingDetailsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingDetails"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl.Of())),
                OrderSetLineItemShippingDetailsActionQueryBuilderDsl.Of);
        }


    }
}
