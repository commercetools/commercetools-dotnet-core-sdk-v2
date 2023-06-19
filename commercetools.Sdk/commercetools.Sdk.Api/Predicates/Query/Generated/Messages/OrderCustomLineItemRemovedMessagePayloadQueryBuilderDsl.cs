using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl
    {
        public OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl>(p, OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl>(p, OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl> CustomLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customLineItem"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl.Of())),
                OrderCustomLineItemRemovedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
