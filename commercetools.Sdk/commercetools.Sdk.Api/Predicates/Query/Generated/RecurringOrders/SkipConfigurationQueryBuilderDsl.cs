using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class SkipConfigurationQueryBuilderDsl
    {
        public SkipConfigurationQueryBuilderDsl()
        {
        }

        public static SkipConfigurationQueryBuilderDsl Of()
        {
            return new SkipConfigurationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SkipConfigurationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<SkipConfigurationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<SkipConfigurationQueryBuilderDsl>(p, SkipConfigurationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<SkipConfigurationQueryBuilderDsl> AsCounter(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.CounterQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.CounterQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SkipConfigurationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.CounterQueryBuilderDsl.Of()),
                SkipConfigurationQueryBuilderDsl.Of);
        }
    }
}
