using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class RecurrencePolicyScheduleQueryBuilderDsl
    {
        public RecurrencePolicyScheduleQueryBuilderDsl()
        {
        }

        public static RecurrencePolicyScheduleQueryBuilderDsl Of()
        {
            return new RecurrencePolicyScheduleQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurrencePolicyScheduleQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicyScheduleQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurrencePolicyScheduleQueryBuilderDsl>(p, RecurrencePolicyScheduleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<RecurrencePolicyScheduleQueryBuilderDsl> AsDayOfMonth(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.DayOfMonthScheduleQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.DayOfMonthScheduleQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicyScheduleQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.DayOfMonthScheduleQueryBuilderDsl.Of()),
                RecurrencePolicyScheduleQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurrencePolicyScheduleQueryBuilderDsl> AsStandard(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.StandardScheduleQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.StandardScheduleQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicyScheduleQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.StandardScheduleQueryBuilderDsl.Of()),
                RecurrencePolicyScheduleQueryBuilderDsl.Of);
        }
    }
}
