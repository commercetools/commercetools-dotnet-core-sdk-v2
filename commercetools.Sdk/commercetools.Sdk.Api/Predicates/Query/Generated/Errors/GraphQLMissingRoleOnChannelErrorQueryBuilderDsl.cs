using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLMissingRoleOnChannelErrorQueryBuilderDsl
    {
        public GraphQLMissingRoleOnChannelErrorQueryBuilderDsl()
        {
        }

        public static GraphQLMissingRoleOnChannelErrorQueryBuilderDsl Of()
        {
            return new GraphQLMissingRoleOnChannelErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLMissingRoleOnChannelErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLMissingRoleOnChannelErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLMissingRoleOnChannelErrorQueryBuilderDsl>(p, GraphQLMissingRoleOnChannelErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLMissingRoleOnChannelErrorQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLMissingRoleOnChannelErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                GraphQLMissingRoleOnChannelErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<GraphQLMissingRoleOnChannelErrorQueryBuilderDsl, string> MissingRole()
        {
            return new ComparisonPredicateBuilder<GraphQLMissingRoleOnChannelErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("missingRole")),
            p => new CombinationQueryPredicate<GraphQLMissingRoleOnChannelErrorQueryBuilderDsl>(p, GraphQLMissingRoleOnChannelErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
