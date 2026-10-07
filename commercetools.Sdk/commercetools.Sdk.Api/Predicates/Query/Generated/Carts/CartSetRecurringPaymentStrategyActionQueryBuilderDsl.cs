// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetRecurringPaymentStrategyActionQueryBuilderDsl
    {
        public CartSetRecurringPaymentStrategyActionQueryBuilderDsl()
        {
        }

        public static CartSetRecurringPaymentStrategyActionQueryBuilderDsl Of()
        {
            return new CartSetRecurringPaymentStrategyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetRecurringPaymentStrategyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetRecurringPaymentStrategyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetRecurringPaymentStrategyActionQueryBuilderDsl>(p, CartSetRecurringPaymentStrategyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetRecurringPaymentStrategyActionQueryBuilderDsl, string> PaymentStrategy()
        {
            return new ComparisonPredicateBuilder<CartSetRecurringPaymentStrategyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentStrategy")),
            p => new CombinationQueryPredicate<CartSetRecurringPaymentStrategyActionQueryBuilderDsl>(p, CartSetRecurringPaymentStrategyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
