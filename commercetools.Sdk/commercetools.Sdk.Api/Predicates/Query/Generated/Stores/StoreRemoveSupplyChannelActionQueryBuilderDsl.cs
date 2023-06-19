using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreRemoveSupplyChannelActionQueryBuilderDsl
    {
        public StoreRemoveSupplyChannelActionQueryBuilderDsl()
        {
        }

        public static StoreRemoveSupplyChannelActionQueryBuilderDsl Of()
        {
            return new StoreRemoveSupplyChannelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreRemoveSupplyChannelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreRemoveSupplyChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreRemoveSupplyChannelActionQueryBuilderDsl>(p, StoreRemoveSupplyChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreRemoveSupplyChannelActionQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreRemoveSupplyChannelActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                StoreRemoveSupplyChannelActionQueryBuilderDsl.Of);
        }


    }
}
