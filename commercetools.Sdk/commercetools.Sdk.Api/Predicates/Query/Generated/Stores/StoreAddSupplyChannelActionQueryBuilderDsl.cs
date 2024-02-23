using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreAddSupplyChannelActionQueryBuilderDsl
    {
        public StoreAddSupplyChannelActionQueryBuilderDsl()
        {
        }

        public static StoreAddSupplyChannelActionQueryBuilderDsl Of()
        {
            return new StoreAddSupplyChannelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreAddSupplyChannelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreAddSupplyChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreAddSupplyChannelActionQueryBuilderDsl>(p, StoreAddSupplyChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreAddSupplyChannelActionQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreAddSupplyChannelActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                StoreAddSupplyChannelActionQueryBuilderDsl.Of);
        }


    }
}
