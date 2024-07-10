using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderCustomLineItemAddedMessagePayloadQueryBuilderDsl
    {
        public OrderCustomLineItemAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderCustomLineItemAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderCustomLineItemAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderCustomLineItemAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderCustomLineItemAddedMessagePayloadQueryBuilderDsl>(p, OrderCustomLineItemAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomLineItemAddedMessagePayloadQueryBuilderDsl> CustomLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomLineItemAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customLineItem"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl.Of())),
                OrderCustomLineItemAddedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
