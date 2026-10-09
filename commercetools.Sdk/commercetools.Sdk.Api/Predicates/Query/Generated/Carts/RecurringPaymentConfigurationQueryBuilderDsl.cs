using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class RecurringPaymentConfigurationQueryBuilderDsl
    {
        public RecurringPaymentConfigurationQueryBuilderDsl()
        {
        }

        public static RecurringPaymentConfigurationQueryBuilderDsl Of()
        {
            return new RecurringPaymentConfigurationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringPaymentConfigurationQueryBuilderDsl, string> PaymentStrategy()
        {
            return new ComparisonPredicateBuilder<RecurringPaymentConfigurationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentStrategy")),
            p => new CombinationQueryPredicate<RecurringPaymentConfigurationQueryBuilderDsl>(p, RecurringPaymentConfigurationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringPaymentConfigurationQueryBuilderDsl> PaymentAllocations(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.RecurringPaymentAllocationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.RecurringPaymentAllocationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringPaymentConfigurationQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentAllocations"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.RecurringPaymentAllocationQueryBuilderDsl.Of())),
                RecurringPaymentConfigurationQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<RecurringPaymentConfigurationQueryBuilderDsl> PaymentAllocations()
        {
            return new CollectionPredicateBuilder<RecurringPaymentConfigurationQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentAllocations")),
                    p => new CombinationQueryPredicate<RecurringPaymentConfigurationQueryBuilderDsl>(p, RecurringPaymentConfigurationQueryBuilderDsl.Of));
        }

    }
}
