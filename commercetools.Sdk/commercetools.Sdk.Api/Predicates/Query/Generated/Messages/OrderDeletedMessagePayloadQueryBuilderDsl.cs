using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderDeletedMessagePayloadQueryBuilderDsl
    {
        public OrderDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderDeletedMessagePayloadQueryBuilderDsl>(p, OrderDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderDeletedMessagePayloadQueryBuilderDsl> Order(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderDeletedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("order"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl.Of())),
                OrderDeletedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
