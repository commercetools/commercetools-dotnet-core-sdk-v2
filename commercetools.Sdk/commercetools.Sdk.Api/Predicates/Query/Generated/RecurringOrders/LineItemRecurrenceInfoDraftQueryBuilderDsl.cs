using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class LineItemRecurrenceInfoDraftQueryBuilderDsl
    {
        public LineItemRecurrenceInfoDraftQueryBuilderDsl()
        {
        }

        public static LineItemRecurrenceInfoDraftQueryBuilderDsl Of()
        {
            return new LineItemRecurrenceInfoDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<LineItemRecurrenceInfoDraftQueryBuilderDsl> RecurrencePolicy(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemRecurrenceInfoDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurrencePolicy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl.Of())),
                LineItemRecurrenceInfoDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<LineItemRecurrenceInfoDraftQueryBuilderDsl, string> PriceSelectionMode()
        {
            return new ComparisonPredicateBuilder<LineItemRecurrenceInfoDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceSelectionMode")),
            p => new CombinationQueryPredicate<LineItemRecurrenceInfoDraftQueryBuilderDsl>(p, LineItemRecurrenceInfoDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
