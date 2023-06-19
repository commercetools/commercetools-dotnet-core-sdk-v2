using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountQueryBuilderDsl
    {
        public CartDiscountQueryBuilderDsl()
        {
        }

        public static CartDiscountQueryBuilderDsl Of()
        {
            return new CartDiscountQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(p, CartDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(p, CartDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(p, CartDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(p, CartDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CartDiscountQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartDiscountQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CartDiscountQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartDiscountQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CartDiscountQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(p, CartDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CartDiscountQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartDiscountQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueQueryBuilderDsl.Of())),
                CartDiscountQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, string> CartPredicate()
        {
            return new ComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartPredicate")),
            p => new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(p, CartDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountQueryBuilderDsl> Target(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("target"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTargetQueryBuilderDsl.Of())),
                CartDiscountQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, string> SortOrder()
        {
            return new ComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sortOrder")),
            p => new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(p, CartDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, bool> IsActive()
        {
            return new ComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isActive")),
            p => new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(p, CartDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(p, CartDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(p, CartDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, bool> RequiresDiscountCode()
        {
            return new ComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("requiresDiscountCode")),
            p => new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(p, CartDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountQueryBuilderDsl> References(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("references"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                CartDiscountQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDiscountQueryBuilderDsl> References()
        {
            return new CollectionPredicateBuilder<CartDiscountQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("references")),
                    p => new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(p, CartDiscountQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, string> StackingMode()
        {
            return new ComparisonPredicateBuilder<CartDiscountQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stackingMode")),
            p => new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(p, CartDiscountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                CartDiscountQueryBuilderDsl.Of);
        }


    }
}
