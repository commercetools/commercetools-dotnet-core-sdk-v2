using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLExactLockConflictErrorQueryBuilderDsl
    {
        public GraphQLExactLockConflictErrorQueryBuilderDsl()
        {
        }

        public static GraphQLExactLockConflictErrorQueryBuilderDsl Of()
        {
            return new GraphQLExactLockConflictErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLExactLockConflictErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLExactLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLExactLockConflictErrorQueryBuilderDsl>(p, GraphQLExactLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLExactLockConflictErrorQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<GraphQLExactLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<GraphQLExactLockConflictErrorQueryBuilderDsl>(p, GraphQLExactLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLExactLockConflictErrorQueryBuilderDsl, string> Currency()
        {
            return new ComparisonPredicateBuilder<GraphQLExactLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currency")),
            p => new CombinationQueryPredicate<GraphQLExactLockConflictErrorQueryBuilderDsl>(p, GraphQLExactLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLExactLockConflictErrorQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<GraphQLExactLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<GraphQLExactLockConflictErrorQueryBuilderDsl>(p, GraphQLExactLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLExactLockConflictErrorQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLExactLockConflictErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                GraphQLExactLockConflictErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<GraphQLExactLockConflictErrorQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLExactLockConflictErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                GraphQLExactLockConflictErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<GraphQLExactLockConflictErrorQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<GraphQLExactLockConflictErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<GraphQLExactLockConflictErrorQueryBuilderDsl>(p, GraphQLExactLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLExactLockConflictErrorQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<GraphQLExactLockConflictErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<GraphQLExactLockConflictErrorQueryBuilderDsl>(p, GraphQLExactLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLExactLockConflictErrorQueryBuilderDsl> RecurrencePolicy(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLExactLockConflictErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurrencePolicy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyReferenceQueryBuilderDsl.Of())),
                GraphQLExactLockConflictErrorQueryBuilderDsl.Of);
        }


    }
}
