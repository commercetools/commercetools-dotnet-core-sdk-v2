using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreRemoveDistributionChannelActionQueryBuilderDsl
    {
        public StoreRemoveDistributionChannelActionQueryBuilderDsl()
        {
        }

        public static StoreRemoveDistributionChannelActionQueryBuilderDsl Of()
        {
            return new StoreRemoveDistributionChannelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreRemoveDistributionChannelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreRemoveDistributionChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreRemoveDistributionChannelActionQueryBuilderDsl>(p, StoreRemoveDistributionChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreRemoveDistributionChannelActionQueryBuilderDsl> DistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreRemoveDistributionChannelActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                StoreRemoveDistributionChannelActionQueryBuilderDsl.Of);
        }


    }
}
