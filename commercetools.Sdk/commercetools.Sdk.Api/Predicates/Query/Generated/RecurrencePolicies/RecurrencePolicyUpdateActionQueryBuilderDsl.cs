using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class RecurrencePolicyUpdateActionQueryBuilderDsl
    {
        public RecurrencePolicyUpdateActionQueryBuilderDsl()
        {
        }

        public static RecurrencePolicyUpdateActionQueryBuilderDsl Of()
        {
            return new RecurrencePolicyUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurrencePolicyUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicyUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<RecurrencePolicyUpdateActionQueryBuilderDsl>(p, RecurrencePolicyUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<RecurrencePolicyUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicySetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicySetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicyUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicySetDescriptionActionQueryBuilderDsl.Of()),
                RecurrencePolicyUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurrencePolicyUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicySetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicySetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicyUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicySetKeyActionQueryBuilderDsl.Of()),
                RecurrencePolicyUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurrencePolicyUpdateActionQueryBuilderDsl> AsSetName(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicySetNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicySetNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicyUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicySetNameActionQueryBuilderDsl.Of()),
                RecurrencePolicyUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurrencePolicyUpdateActionQueryBuilderDsl> AsSetSchedule(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicySetScheduleActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicySetScheduleActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicyUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicySetScheduleActionQueryBuilderDsl.Of()),
                RecurrencePolicyUpdateActionQueryBuilderDsl.Of);
        }
    }
}
