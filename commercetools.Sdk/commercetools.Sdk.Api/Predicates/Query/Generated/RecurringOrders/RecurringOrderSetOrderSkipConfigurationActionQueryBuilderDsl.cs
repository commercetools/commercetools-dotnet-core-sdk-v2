using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl
    {
        public RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl()
        {
        }

        public static RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl Of()
        {
            return new RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl>(p, RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl> SkipConfiguration(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.SkipConfigurationDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.SkipConfigurationDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("skipConfiguration"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.SkipConfigurationDraftQueryBuilderDsl.Of())),
                RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl, DateTime> UpdatedExpiresAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("updatedExpiresAt")),
            p => new CombinationQueryPredicate<RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl>(p, RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
