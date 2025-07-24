using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class CustomLineItemRecurrenceInfoDraftQueryBuilderDsl
    {
        public CustomLineItemRecurrenceInfoDraftQueryBuilderDsl()
        {
        }

        public static CustomLineItemRecurrenceInfoDraftQueryBuilderDsl Of()
        {
            return new CustomLineItemRecurrenceInfoDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<CustomLineItemRecurrenceInfoDraftQueryBuilderDsl> RecurrencePolicy(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemRecurrenceInfoDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurrencePolicy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl.Of())),
                CustomLineItemRecurrenceInfoDraftQueryBuilderDsl.Of);
        }


    }
}
