using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class RecurringPaymentAllocationQueryBuilderDsl
    {
        public RecurringPaymentAllocationQueryBuilderDsl()
        {
        }

        public static RecurringPaymentAllocationQueryBuilderDsl Of()
        {
            return new RecurringPaymentAllocationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringPaymentAllocationQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<RecurringPaymentAllocationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<RecurringPaymentAllocationQueryBuilderDsl>(p, RecurringPaymentAllocationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringPaymentAllocationQueryBuilderDsl> PaymentMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringPaymentAllocationQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentMethod"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodReferenceQueryBuilderDsl.Of())),
                RecurringPaymentAllocationQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<RecurringPaymentAllocationQueryBuilderDsl> Allocation(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.AllocationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.AllocationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringPaymentAllocationQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("allocation"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.AllocationQueryBuilderDsl.Of())),
                RecurringPaymentAllocationQueryBuilderDsl.Of);
        }


    }
}
