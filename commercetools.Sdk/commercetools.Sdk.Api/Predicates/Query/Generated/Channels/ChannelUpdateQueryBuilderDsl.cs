using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Channels
{

    public partial class ChannelUpdateQueryBuilderDsl
    {
        public ChannelUpdateQueryBuilderDsl()
        {
        }

        public static ChannelUpdateQueryBuilderDsl Of()
        {
            return new ChannelUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ChannelUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ChannelUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ChannelUpdateQueryBuilderDsl>(p, ChannelUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ChannelUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelUpdateActionQueryBuilderDsl.Of())),
                ChannelUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ChannelUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<ChannelUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<ChannelUpdateQueryBuilderDsl>(p, ChannelUpdateQueryBuilderDsl.Of));
        }

    }
}
