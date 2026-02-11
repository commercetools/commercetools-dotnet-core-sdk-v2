using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLValidityLockConflictErrorQueryBuilderDsl
    {
        public GraphQLValidityLockConflictErrorQueryBuilderDsl()
        {
        }

        public static GraphQLValidityLockConflictErrorQueryBuilderDsl Of()
        {
            return new GraphQLValidityLockConflictErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLValidityLockConflictErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLValidityLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLValidityLockConflictErrorQueryBuilderDsl>(p, GraphQLValidityLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLValidityLockConflictErrorQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<GraphQLValidityLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<GraphQLValidityLockConflictErrorQueryBuilderDsl>(p, GraphQLValidityLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLValidityLockConflictErrorQueryBuilderDsl, string> Currency()
        {
            return new ComparisonPredicateBuilder<GraphQLValidityLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currency")),
            p => new CombinationQueryPredicate<GraphQLValidityLockConflictErrorQueryBuilderDsl>(p, GraphQLValidityLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLValidityLockConflictErrorQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<GraphQLValidityLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<GraphQLValidityLockConflictErrorQueryBuilderDsl>(p, GraphQLValidityLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLValidityLockConflictErrorQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLValidityLockConflictErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                GraphQLValidityLockConflictErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<GraphQLValidityLockConflictErrorQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLValidityLockConflictErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                GraphQLValidityLockConflictErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<GraphQLValidityLockConflictErrorQueryBuilderDsl> RecurrencePolicy(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLValidityLockConflictErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurrencePolicy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl.Of())),
                GraphQLValidityLockConflictErrorQueryBuilderDsl.Of);
        }


    }
}
