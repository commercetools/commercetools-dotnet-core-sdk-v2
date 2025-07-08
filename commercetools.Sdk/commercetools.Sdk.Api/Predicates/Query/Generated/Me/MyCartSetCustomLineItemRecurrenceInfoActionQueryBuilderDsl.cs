using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl
    {
        public MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl()
        {
        }

        public static MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl Of()
        {
            return new MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl>(p, MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl>(p, MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl>(p, MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl> RecurrenceInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.CustomLineItemRecurrenceInfoDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.CustomLineItemRecurrenceInfoDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurrenceInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.CustomLineItemRecurrenceInfoDraftQueryBuilderDsl.Of())),
                MyCartSetCustomLineItemRecurrenceInfoActionQueryBuilderDsl.Of);
        }


    }
}
