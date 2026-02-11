using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ValidityLockConflictErrorQueryBuilderDsl
    {
        public ValidityLockConflictErrorQueryBuilderDsl()
        {
        }

        public static ValidityLockConflictErrorQueryBuilderDsl Of()
        {
            return new ValidityLockConflictErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ValidityLockConflictErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ValidityLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ValidityLockConflictErrorQueryBuilderDsl>(p, ValidityLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ValidityLockConflictErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ValidityLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ValidityLockConflictErrorQueryBuilderDsl>(p, ValidityLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ValidityLockConflictErrorQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ValidityLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ValidityLockConflictErrorQueryBuilderDsl>(p, ValidityLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ValidityLockConflictErrorQueryBuilderDsl, string> Currency()
        {
            return new ComparisonPredicateBuilder<ValidityLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currency")),
            p => new CombinationQueryPredicate<ValidityLockConflictErrorQueryBuilderDsl>(p, ValidityLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ValidityLockConflictErrorQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<ValidityLockConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<ValidityLockConflictErrorQueryBuilderDsl>(p, ValidityLockConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ValidityLockConflictErrorQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ValidityLockConflictErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                ValidityLockConflictErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ValidityLockConflictErrorQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ValidityLockConflictErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                ValidityLockConflictErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ValidityLockConflictErrorQueryBuilderDsl> RecurrencePolicy(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ValidityLockConflictErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurrencePolicy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl.Of())),
                ValidityLockConflictErrorQueryBuilderDsl.Of);
        }


    }
}
