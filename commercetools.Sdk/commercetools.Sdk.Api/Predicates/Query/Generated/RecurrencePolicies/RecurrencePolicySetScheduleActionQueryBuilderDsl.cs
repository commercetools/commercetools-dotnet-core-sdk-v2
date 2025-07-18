using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class RecurrencePolicySetScheduleActionQueryBuilderDsl
    {
        public RecurrencePolicySetScheduleActionQueryBuilderDsl()
        {
        }

        public static RecurrencePolicySetScheduleActionQueryBuilderDsl Of()
        {
            return new RecurrencePolicySetScheduleActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurrencePolicySetScheduleActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicySetScheduleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<RecurrencePolicySetScheduleActionQueryBuilderDsl>(p, RecurrencePolicySetScheduleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurrencePolicySetScheduleActionQueryBuilderDsl> Schedule(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyScheduleDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyScheduleDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicySetScheduleActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("schedule"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyScheduleDraftQueryBuilderDsl.Of())),
                RecurrencePolicySetScheduleActionQueryBuilderDsl.Of);
        }


    }
}
