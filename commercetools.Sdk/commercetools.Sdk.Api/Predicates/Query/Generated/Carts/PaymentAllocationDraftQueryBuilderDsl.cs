using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class PaymentAllocationDraftQueryBuilderDsl
    {
        public PaymentAllocationDraftQueryBuilderDsl()
        {
        }

        public static PaymentAllocationDraftQueryBuilderDsl Of()
        {
            return new PaymentAllocationDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentAllocationDraftQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<PaymentAllocationDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<PaymentAllocationDraftQueryBuilderDsl>(p, PaymentAllocationDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentAllocationDraftQueryBuilderDsl> PaymentMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentAllocationDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentMethod"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodReferenceQueryBuilderDsl.Of())),
                PaymentAllocationDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentAllocationDraftQueryBuilderDsl> Allocation(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.AllocationDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.AllocationDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentAllocationDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("allocation"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.AllocationDraftQueryBuilderDsl.Of())),
                PaymentAllocationDraftQueryBuilderDsl.Of);
        }


    }
}
