using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetRecurringPaymentConfigurationActionQueryBuilderDsl
    {
        public CartSetRecurringPaymentConfigurationActionQueryBuilderDsl()
        {
        }

        public static CartSetRecurringPaymentConfigurationActionQueryBuilderDsl Of()
        {
            return new CartSetRecurringPaymentConfigurationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetRecurringPaymentConfigurationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetRecurringPaymentConfigurationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetRecurringPaymentConfigurationActionQueryBuilderDsl>(p, CartSetRecurringPaymentConfigurationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetRecurringPaymentConfigurationActionQueryBuilderDsl> RecurringPaymentConfiguration(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.RecurringPaymentConfigurationDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.RecurringPaymentConfigurationDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetRecurringPaymentConfigurationActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurringPaymentConfiguration"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.RecurringPaymentConfigurationDraftQueryBuilderDsl.Of())),
                CartSetRecurringPaymentConfigurationActionQueryBuilderDsl.Of);
        }


    }
}
