using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetLineItemRecurrenceInfoActionQueryBuilderDsl
    {
        public CartSetLineItemRecurrenceInfoActionQueryBuilderDsl()
        {
        }

        public static CartSetLineItemRecurrenceInfoActionQueryBuilderDsl Of()
        {
            return new CartSetLineItemRecurrenceInfoActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetLineItemRecurrenceInfoActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemRecurrenceInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetLineItemRecurrenceInfoActionQueryBuilderDsl>(p, CartSetLineItemRecurrenceInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetLineItemRecurrenceInfoActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemRecurrenceInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<CartSetLineItemRecurrenceInfoActionQueryBuilderDsl>(p, CartSetLineItemRecurrenceInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetLineItemRecurrenceInfoActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemRecurrenceInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<CartSetLineItemRecurrenceInfoActionQueryBuilderDsl>(p, CartSetLineItemRecurrenceInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetLineItemRecurrenceInfoActionQueryBuilderDsl> RecurrenceInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.LineItemRecurrenceInfoDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.LineItemRecurrenceInfoDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetLineItemRecurrenceInfoActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurrenceInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.LineItemRecurrenceInfoDraftQueryBuilderDsl.Of())),
                CartSetLineItemRecurrenceInfoActionQueryBuilderDsl.Of);
        }


    }
}
