using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditPreviewSuccessQueryBuilderDsl
    {
        public OrderEditPreviewSuccessQueryBuilderDsl()
        {
        }

        public static OrderEditPreviewSuccessQueryBuilderDsl Of()
        {
            return new OrderEditPreviewSuccessQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditPreviewSuccessQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderEditPreviewSuccessQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderEditPreviewSuccessQueryBuilderDsl>(p, OrderEditPreviewSuccessQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEditPreviewSuccessQueryBuilderDsl> Preview(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditPreviewSuccessQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("preview"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.StagedOrderQueryBuilderDsl.Of())),
                OrderEditPreviewSuccessQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderEditPreviewSuccessQueryBuilderDsl> MessagePayloads(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.MessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.MessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditPreviewSuccessQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("messagePayloads"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.MessagePayloadQueryBuilderDsl.Of())),
                OrderEditPreviewSuccessQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderEditPreviewSuccessQueryBuilderDsl> MessagePayloads()
        {
            return new CollectionPredicateBuilder<OrderEditPreviewSuccessQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("messagePayloads")),
                    p => new CombinationQueryPredicate<OrderEditPreviewSuccessQueryBuilderDsl>(p, OrderEditPreviewSuccessQueryBuilderDsl.Of));
        }

    }
}
