using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl
    {
        public OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl>(p, OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl>(p, OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl> DistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                OrderLineItemDistributionChannelSetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
