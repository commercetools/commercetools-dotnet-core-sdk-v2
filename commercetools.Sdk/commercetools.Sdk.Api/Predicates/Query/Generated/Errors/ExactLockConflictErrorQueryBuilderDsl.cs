using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ExactLockConflictErrorQueryBuilderDsl
    {
        public ExactLockConflictErrorQueryBuilderDsl()
        {
        }

        public static ExactLockConflictErrorQueryBuilderDsl Of()
        {
            return new ExactLockConflictErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExactLockConflictErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ExactLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ExactLockConflictErrorQueryBuilderDsl>(p, ExactLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExactLockConflictErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ExactLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ExactLockConflictErrorQueryBuilderDsl>(p, ExactLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExactLockConflictErrorQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ExactLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ExactLockConflictErrorQueryBuilderDsl>(p, ExactLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExactLockConflictErrorQueryBuilderDsl, string> Currency()
        {
            return new ComparisonPredicateBuilder<ExactLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currency")),
            p => new CombinationQueryPredicate<ExactLockConflictErrorQueryBuilderDsl>(p, ExactLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExactLockConflictErrorQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<ExactLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<ExactLockConflictErrorQueryBuilderDsl>(p, ExactLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExactLockConflictErrorQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExactLockConflictErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                ExactLockConflictErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ExactLockConflictErrorQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExactLockConflictErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                ExactLockConflictErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ExactLockConflictErrorQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<ExactLockConflictErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<ExactLockConflictErrorQueryBuilderDsl>(p, ExactLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExactLockConflictErrorQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<ExactLockConflictErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<ExactLockConflictErrorQueryBuilderDsl>(p, ExactLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExactLockConflictErrorQueryBuilderDsl> RecurrencePolicy(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExactLockConflictErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurrencePolicy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyReferenceQueryBuilderDsl.Of())),
                ExactLockConflictErrorQueryBuilderDsl.Of);
        }


    }
}
