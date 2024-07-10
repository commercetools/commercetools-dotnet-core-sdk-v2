using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class MissingRoleOnChannelErrorQueryBuilderDsl
    {
        public MissingRoleOnChannelErrorQueryBuilderDsl()
        {
        }

        public static MissingRoleOnChannelErrorQueryBuilderDsl Of()
        {
            return new MissingRoleOnChannelErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MissingRoleOnChannelErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<MissingRoleOnChannelErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<MissingRoleOnChannelErrorQueryBuilderDsl>(p, MissingRoleOnChannelErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MissingRoleOnChannelErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<MissingRoleOnChannelErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<MissingRoleOnChannelErrorQueryBuilderDsl>(p, MissingRoleOnChannelErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MissingRoleOnChannelErrorQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MissingRoleOnChannelErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                MissingRoleOnChannelErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<MissingRoleOnChannelErrorQueryBuilderDsl, string> MissingRole()
        {
            return new ComparisonPredicateBuilder<MissingRoleOnChannelErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("missingRole")),
            p => new CombinationQueryPredicate<MissingRoleOnChannelErrorQueryBuilderDsl>(p, MissingRoleOnChannelErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
