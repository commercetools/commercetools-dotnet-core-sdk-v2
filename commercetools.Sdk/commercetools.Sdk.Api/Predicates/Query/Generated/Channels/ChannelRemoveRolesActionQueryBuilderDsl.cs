using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Channels
{

    public partial class ChannelRemoveRolesActionQueryBuilderDsl
    {
        public ChannelRemoveRolesActionQueryBuilderDsl()
        {
        }

        public static ChannelRemoveRolesActionQueryBuilderDsl Of()
        {
            return new ChannelRemoveRolesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ChannelRemoveRolesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ChannelRemoveRolesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ChannelRemoveRolesActionQueryBuilderDsl>(p, ChannelRemoveRolesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ChannelRemoveRolesActionQueryBuilderDsl, string> Roles()
        {
            return new ComparableCollectionPredicateBuilder<ChannelRemoveRolesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("roles")),
            p => new CombinationQueryPredicate<ChannelRemoveRolesActionQueryBuilderDsl>(p, ChannelRemoveRolesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
