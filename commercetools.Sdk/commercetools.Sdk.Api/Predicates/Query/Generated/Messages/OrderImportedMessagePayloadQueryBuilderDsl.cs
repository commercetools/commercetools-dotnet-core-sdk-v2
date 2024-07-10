using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderImportedMessagePayloadQueryBuilderDsl
    {
        public OrderImportedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderImportedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderImportedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderImportedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderImportedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderImportedMessagePayloadQueryBuilderDsl>(p, OrderImportedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderImportedMessagePayloadQueryBuilderDsl> Order(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("order"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl.Of())),
                OrderImportedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
