using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl
    {
        public CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl()
        {
        }

        public static CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl Of()
        {
            return new CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl>(p, CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl>(p, CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl>(p, CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl> RecurrenceInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.CustomLineItemRecurrenceInfoDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.CustomLineItemRecurrenceInfoDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurrenceInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.CustomLineItemRecurrenceInfoDraftQueryBuilderDsl.Of())),
                CartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl.Of);
        }


    }
}
