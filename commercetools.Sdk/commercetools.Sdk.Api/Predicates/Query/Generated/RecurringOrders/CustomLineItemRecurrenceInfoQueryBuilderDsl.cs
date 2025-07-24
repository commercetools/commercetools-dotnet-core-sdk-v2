using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class CustomLineItemRecurrenceInfoQueryBuilderDsl
    {
        public CustomLineItemRecurrenceInfoQueryBuilderDsl()
        {
        }

        public static CustomLineItemRecurrenceInfoQueryBuilderDsl Of()
        {
            return new CustomLineItemRecurrenceInfoQueryBuilderDsl();
        }

        public CombinationQueryPredicate<CustomLineItemRecurrenceInfoQueryBuilderDsl> RecurrencePolicy(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemRecurrenceInfoQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurrencePolicy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyReferenceQueryBuilderDsl.Of())),
                CustomLineItemRecurrenceInfoQueryBuilderDsl.Of);
        }


    }
}
