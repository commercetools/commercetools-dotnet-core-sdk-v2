using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderLineItemAddedMessagePayloadQueryBuilderDsl
    {
        public OrderLineItemAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderLineItemAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderLineItemAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderLineItemAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderLineItemAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderLineItemAddedMessagePayloadQueryBuilderDsl>(p, OrderLineItemAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderLineItemAddedMessagePayloadQueryBuilderDsl> LineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lineItem"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl.Of())),
                OrderLineItemAddedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderLineItemAddedMessagePayloadQueryBuilderDsl, long> AddedQuantity()
        {
            return new ComparisonPredicateBuilder<OrderLineItemAddedMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedQuantity")),
            p => new CombinationQueryPredicate<OrderLineItemAddedMessagePayloadQueryBuilderDsl>(p, OrderLineItemAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
