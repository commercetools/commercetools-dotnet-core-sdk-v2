using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class LineItemRecurrenceInfoQueryBuilderDsl
    {
        public LineItemRecurrenceInfoQueryBuilderDsl()
        {
        }

        public static LineItemRecurrenceInfoQueryBuilderDsl Of()
        {
            return new LineItemRecurrenceInfoQueryBuilderDsl();
        }

        public CombinationQueryPredicate<LineItemRecurrenceInfoQueryBuilderDsl> RecurrencePolicy(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemRecurrenceInfoQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurrencePolicy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyReferenceQueryBuilderDsl.Of())),
                LineItemRecurrenceInfoQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<LineItemRecurrenceInfoQueryBuilderDsl, string> PriceSelectionMode()
        {
            return new ComparisonPredicateBuilder<LineItemRecurrenceInfoQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceSelectionMode")),
            p => new CombinationQueryPredicate<LineItemRecurrenceInfoQueryBuilderDsl>(p, LineItemRecurrenceInfoQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
