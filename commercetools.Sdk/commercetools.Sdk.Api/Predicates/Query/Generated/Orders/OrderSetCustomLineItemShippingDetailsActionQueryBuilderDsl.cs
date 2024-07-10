using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl
    {
        public OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl()
        {
        }

        public static OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl Of()
        {
            return new OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl>(p, OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl>(p, OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl>(p, OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl> ShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingDetails"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl.Of())),
                OrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl.Of);
        }


    }
}
