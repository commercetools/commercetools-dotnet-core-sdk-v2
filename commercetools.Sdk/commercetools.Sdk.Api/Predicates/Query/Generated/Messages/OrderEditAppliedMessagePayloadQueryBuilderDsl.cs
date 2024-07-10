using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderEditAppliedMessagePayloadQueryBuilderDsl
    {
        public OrderEditAppliedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderEditAppliedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderEditAppliedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditAppliedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderEditAppliedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderEditAppliedMessagePayloadQueryBuilderDsl>(p, OrderEditAppliedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEditAppliedMessagePayloadQueryBuilderDsl> Edit(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditAppliedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("edit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditQueryBuilderDsl.Of())),
                OrderEditAppliedMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderEditAppliedMessagePayloadQueryBuilderDsl> Result(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditAppliedQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditAppliedQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditAppliedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("result"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditAppliedQueryBuilderDsl.Of())),
                OrderEditAppliedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
