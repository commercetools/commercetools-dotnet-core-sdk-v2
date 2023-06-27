using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl
    {
        public StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl>(p, StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl>(p, StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl>(p, StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl> DistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderSetLineItemDistributionChannelActionQueryBuilderDsl.Of);
        }


    }
}
