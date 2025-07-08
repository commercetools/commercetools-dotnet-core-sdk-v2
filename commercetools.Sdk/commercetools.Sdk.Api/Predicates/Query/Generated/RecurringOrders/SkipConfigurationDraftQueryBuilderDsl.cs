using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class SkipConfigurationDraftQueryBuilderDsl
    {
        public SkipConfigurationDraftQueryBuilderDsl()
        {
        }

        public static SkipConfigurationDraftQueryBuilderDsl Of()
        {
            return new SkipConfigurationDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SkipConfigurationDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<SkipConfigurationDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<SkipConfigurationDraftQueryBuilderDsl>(p, SkipConfigurationDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<SkipConfigurationDraftQueryBuilderDsl> AsCounter(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.CounterDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.CounterDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SkipConfigurationDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.CounterDraftQueryBuilderDsl.Of()),
                SkipConfigurationDraftQueryBuilderDsl.Of);
        }
    }
}
