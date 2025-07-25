using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class RecurrencePolicyScheduleDraftQueryBuilderDsl
    {
        public RecurrencePolicyScheduleDraftQueryBuilderDsl()
        {
        }

        public static RecurrencePolicyScheduleDraftQueryBuilderDsl Of()
        {
            return new RecurrencePolicyScheduleDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurrencePolicyScheduleDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicyScheduleDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurrencePolicyScheduleDraftQueryBuilderDsl>(p, RecurrencePolicyScheduleDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<RecurrencePolicyScheduleDraftQueryBuilderDsl> AsDayOfMonth(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.DayOfMonthScheduleDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.DayOfMonthScheduleDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicyScheduleDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.DayOfMonthScheduleDraftQueryBuilderDsl.Of()),
                RecurrencePolicyScheduleDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurrencePolicyScheduleDraftQueryBuilderDsl> AsStandard(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.StandardScheduleDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.StandardScheduleDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicyScheduleDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.StandardScheduleDraftQueryBuilderDsl.Of()),
                RecurrencePolicyScheduleDraftQueryBuilderDsl.Of);
        }
    }
}
