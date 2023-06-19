using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartSetLineItemSupplyChannelActionQueryBuilderDsl
    {
        public MyCartSetLineItemSupplyChannelActionQueryBuilderDsl()
        {
        }

        public static MyCartSetLineItemSupplyChannelActionQueryBuilderDsl Of()
        {
            return new MyCartSetLineItemSupplyChannelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartSetLineItemSupplyChannelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartSetLineItemSupplyChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartSetLineItemSupplyChannelActionQueryBuilderDsl>(p, MyCartSetLineItemSupplyChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartSetLineItemSupplyChannelActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<MyCartSetLineItemSupplyChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<MyCartSetLineItemSupplyChannelActionQueryBuilderDsl>(p, MyCartSetLineItemSupplyChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCartSetLineItemSupplyChannelActionQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartSetLineItemSupplyChannelActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                MyCartSetLineItemSupplyChannelActionQueryBuilderDsl.Of);
        }


    }
}
