using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Channels
{

    public partial class ChannelChangeKeyActionQueryBuilderDsl
    {
        public ChannelChangeKeyActionQueryBuilderDsl()
        {
        }

        public static ChannelChangeKeyActionQueryBuilderDsl Of()
        {
            return new ChannelChangeKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ChannelChangeKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ChannelChangeKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ChannelChangeKeyActionQueryBuilderDsl>(p, ChannelChangeKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ChannelChangeKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ChannelChangeKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ChannelChangeKeyActionQueryBuilderDsl>(p, ChannelChangeKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
