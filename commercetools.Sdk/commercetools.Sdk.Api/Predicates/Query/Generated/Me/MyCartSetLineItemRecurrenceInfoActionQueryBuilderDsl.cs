using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl
    {
        public MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl()
        {
        }

        public static MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl Of()
        {
            return new MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl>(p, MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl>(p, MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl>(p, MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl> RecurrenceInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.LineItemRecurrenceInfoDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.LineItemRecurrenceInfoDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurrenceInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.LineItemRecurrenceInfoDraftQueryBuilderDsl.Of())),
                MyCartSetLineItemRecurrenceInfoActionQueryBuilderDsl.Of);
        }


    }
}
