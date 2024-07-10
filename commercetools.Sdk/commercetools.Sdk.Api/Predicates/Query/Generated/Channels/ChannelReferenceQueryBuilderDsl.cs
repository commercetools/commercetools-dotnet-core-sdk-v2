using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Channels
{

    public partial class ChannelReferenceQueryBuilderDsl
    {
        public ChannelReferenceQueryBuilderDsl()
        {
        }

        public static ChannelReferenceQueryBuilderDsl Of()
        {
            return new ChannelReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ChannelReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ChannelReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ChannelReferenceQueryBuilderDsl>(p, ChannelReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ChannelReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ChannelReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ChannelReferenceQueryBuilderDsl>(p, ChannelReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ChannelReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelQueryBuilderDsl.Of())),
                ChannelReferenceQueryBuilderDsl.Of);
        }


    }
}
