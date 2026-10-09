// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartRemoveRecurringPaymentAllocationActionQueryBuilderDsl
    {
        public CartRemoveRecurringPaymentAllocationActionQueryBuilderDsl()
        {
        }

        public static CartRemoveRecurringPaymentAllocationActionQueryBuilderDsl Of()
        {
            return new CartRemoveRecurringPaymentAllocationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartRemoveRecurringPaymentAllocationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartRemoveRecurringPaymentAllocationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartRemoveRecurringPaymentAllocationActionQueryBuilderDsl>(p, CartRemoveRecurringPaymentAllocationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartRemoveRecurringPaymentAllocationActionQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CartRemoveRecurringPaymentAllocationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CartRemoveRecurringPaymentAllocationActionQueryBuilderDsl>(p, CartRemoveRecurringPaymentAllocationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
