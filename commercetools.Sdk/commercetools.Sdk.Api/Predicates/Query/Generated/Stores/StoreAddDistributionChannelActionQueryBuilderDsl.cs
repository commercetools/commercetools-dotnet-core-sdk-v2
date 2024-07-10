using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreAddDistributionChannelActionQueryBuilderDsl
    {
        public StoreAddDistributionChannelActionQueryBuilderDsl()
        {
        }

        public static StoreAddDistributionChannelActionQueryBuilderDsl Of()
        {
            return new StoreAddDistributionChannelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreAddDistributionChannelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreAddDistributionChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreAddDistributionChannelActionQueryBuilderDsl>(p, StoreAddDistributionChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreAddDistributionChannelActionQueryBuilderDsl> DistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreAddDistributionChannelActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                StoreAddDistributionChannelActionQueryBuilderDsl.Of);
        }


    }
}
