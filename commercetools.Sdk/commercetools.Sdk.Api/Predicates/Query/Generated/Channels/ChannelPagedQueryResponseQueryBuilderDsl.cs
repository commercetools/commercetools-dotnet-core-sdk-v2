using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Channels
{

    public partial class ChannelPagedQueryResponseQueryBuilderDsl
    {
        public ChannelPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static ChannelPagedQueryResponseQueryBuilderDsl Of()
        {
            return new ChannelPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ChannelPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ChannelPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ChannelPagedQueryResponseQueryBuilderDsl>(p, ChannelPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ChannelPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ChannelPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ChannelPagedQueryResponseQueryBuilderDsl>(p, ChannelPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ChannelPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ChannelPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ChannelPagedQueryResponseQueryBuilderDsl>(p, ChannelPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ChannelPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<ChannelPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<ChannelPagedQueryResponseQueryBuilderDsl>(p, ChannelPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ChannelPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelQueryBuilderDsl.Of())),
                ChannelPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ChannelPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ChannelPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ChannelPagedQueryResponseQueryBuilderDsl>(p, ChannelPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
