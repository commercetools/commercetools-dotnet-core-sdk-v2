using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartSetLineItemDistributionChannelActionQueryBuilderDsl
    {
        public MyCartSetLineItemDistributionChannelActionQueryBuilderDsl()
        {
        }

        public static MyCartSetLineItemDistributionChannelActionQueryBuilderDsl Of()
        {
            return new MyCartSetLineItemDistributionChannelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartSetLineItemDistributionChannelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartSetLineItemDistributionChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartSetLineItemDistributionChannelActionQueryBuilderDsl>(p, MyCartSetLineItemDistributionChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartSetLineItemDistributionChannelActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<MyCartSetLineItemDistributionChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<MyCartSetLineItemDistributionChannelActionQueryBuilderDsl>(p, MyCartSetLineItemDistributionChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartSetLineItemDistributionChannelActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<MyCartSetLineItemDistributionChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<MyCartSetLineItemDistributionChannelActionQueryBuilderDsl>(p, MyCartSetLineItemDistributionChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCartSetLineItemDistributionChannelActionQueryBuilderDsl> DistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartSetLineItemDistributionChannelActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                MyCartSetLineItemDistributionChannelActionQueryBuilderDsl.Of);
        }


    }
}
