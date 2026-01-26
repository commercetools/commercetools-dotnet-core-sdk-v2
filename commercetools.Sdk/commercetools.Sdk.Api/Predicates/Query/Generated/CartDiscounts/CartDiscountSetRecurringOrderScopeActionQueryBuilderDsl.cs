using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountSetRecurringOrderScopeActionQueryBuilderDsl
    {
        public CartDiscountSetRecurringOrderScopeActionQueryBuilderDsl()
        {
        }

        public static CartDiscountSetRecurringOrderScopeActionQueryBuilderDsl Of()
        {
            return new CartDiscountSetRecurringOrderScopeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountSetRecurringOrderScopeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountSetRecurringOrderScopeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountSetRecurringOrderScopeActionQueryBuilderDsl>(p, CartDiscountSetRecurringOrderScopeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountSetRecurringOrderScopeActionQueryBuilderDsl> RecurringOrderScope(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderScopeDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderScopeDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountSetRecurringOrderScopeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurringOrderScope"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderScopeDraftQueryBuilderDsl.Of())),
                CartDiscountSetRecurringOrderScopeActionQueryBuilderDsl.Of);
        }


    }
}
