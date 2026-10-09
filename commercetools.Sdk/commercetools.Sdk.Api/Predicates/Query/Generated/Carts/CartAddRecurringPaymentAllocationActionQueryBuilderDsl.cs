using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartAddRecurringPaymentAllocationActionQueryBuilderDsl
    {
        public CartAddRecurringPaymentAllocationActionQueryBuilderDsl()
        {
        }

        public static CartAddRecurringPaymentAllocationActionQueryBuilderDsl Of()
        {
            return new CartAddRecurringPaymentAllocationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartAddRecurringPaymentAllocationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartAddRecurringPaymentAllocationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartAddRecurringPaymentAllocationActionQueryBuilderDsl>(p, CartAddRecurringPaymentAllocationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartAddRecurringPaymentAllocationActionQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CartAddRecurringPaymentAllocationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CartAddRecurringPaymentAllocationActionQueryBuilderDsl>(p, CartAddRecurringPaymentAllocationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartAddRecurringPaymentAllocationActionQueryBuilderDsl> PaymentMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddRecurringPaymentAllocationActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentMethod"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodReferenceQueryBuilderDsl.Of())),
                CartAddRecurringPaymentAllocationActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartAddRecurringPaymentAllocationActionQueryBuilderDsl> Allocation(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.AllocationDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.AllocationDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddRecurringPaymentAllocationActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("allocation"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.AllocationDraftQueryBuilderDsl.Of())),
                CartAddRecurringPaymentAllocationActionQueryBuilderDsl.Of);
        }


    }
}
