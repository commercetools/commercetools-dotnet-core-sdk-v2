using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountDraftQueryBuilderDsl
    {
        public CartDiscountDraftQueryBuilderDsl()
        {
        }

        public static CartDiscountDraftQueryBuilderDsl Of()
        {
            return new CartDiscountDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CartDiscountDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartDiscountDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CartDiscountDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(p, CartDiscountDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CartDiscountDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueDraftQueryBuilderDsl.Of())),
                CartDiscountDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartDiscountDraftQueryBuilderDsl, string> CartPredicate()
        {
            return new ComparisonPredicateBuilder<CartDiscountDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartPredicate")),
            p => new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(p, CartDiscountDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl> Target(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("target"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTargetQueryBuilderDsl.Of())),
                CartDiscountDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartDiscountDraftQueryBuilderDsl, string> SortOrder()
        {
            return new ComparisonPredicateBuilder<CartDiscountDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sortOrder")),
            p => new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(p, CartDiscountDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                CartDiscountDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDiscountDraftQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<CartDiscountDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(p, CartDiscountDraftQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<CartDiscountDraftQueryBuilderDsl, bool> IsActive()
        {
            return new ComparisonPredicateBuilder<CartDiscountDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isActive")),
            p => new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(p, CartDiscountDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountDraftQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<CartDiscountDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(p, CartDiscountDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountDraftQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<CartDiscountDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(p, CartDiscountDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountDraftQueryBuilderDsl, bool> RequiresDiscountCode()
        {
            return new ComparisonPredicateBuilder<CartDiscountDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("requiresDiscountCode")),
            p => new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(p, CartDiscountDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountDraftQueryBuilderDsl, string> StackingMode()
        {
            return new ComparisonPredicateBuilder<CartDiscountDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stackingMode")),
            p => new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(p, CartDiscountDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                CartDiscountDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl> DiscountGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupResourceIdentifierQueryBuilderDsl.Of())),
                CartDiscountDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl> RecurringOrderScope(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderScopeDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderScopeDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurringOrderScope"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderScopeDraftQueryBuilderDsl.Of())),
                CartDiscountDraftQueryBuilderDsl.Of);
        }


    }
}
