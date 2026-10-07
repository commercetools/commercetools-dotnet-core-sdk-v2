using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class RecurringPaymentConfigurationDraftQueryBuilderDsl
    {
        public RecurringPaymentConfigurationDraftQueryBuilderDsl()
        {
        }

        public static RecurringPaymentConfigurationDraftQueryBuilderDsl Of()
        {
            return new RecurringPaymentConfigurationDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringPaymentConfigurationDraftQueryBuilderDsl, string> PaymentStrategy()
        {
            return new ComparisonPredicateBuilder<RecurringPaymentConfigurationDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentStrategy")),
            p => new CombinationQueryPredicate<RecurringPaymentConfigurationDraftQueryBuilderDsl>(p, RecurringPaymentConfigurationDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringPaymentConfigurationDraftQueryBuilderDsl> PaymentAllocations(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.PaymentAllocationDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.PaymentAllocationDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringPaymentConfigurationDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentAllocations"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.PaymentAllocationDraftQueryBuilderDsl.Of())),
                RecurringPaymentConfigurationDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<RecurringPaymentConfigurationDraftQueryBuilderDsl> PaymentAllocations()
        {
            return new CollectionPredicateBuilder<RecurringPaymentConfigurationDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentAllocations")),
                    p => new CombinationQueryPredicate<RecurringPaymentConfigurationDraftQueryBuilderDsl>(p, RecurringPaymentConfigurationDraftQueryBuilderDsl.Of));
        }

    }
}
