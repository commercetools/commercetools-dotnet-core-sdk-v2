using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountSetDiscountGroupActionQueryBuilderDsl
    {
        public CartDiscountSetDiscountGroupActionQueryBuilderDsl()
        {
        }

        public static CartDiscountSetDiscountGroupActionQueryBuilderDsl Of()
        {
            return new CartDiscountSetDiscountGroupActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountSetDiscountGroupActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountSetDiscountGroupActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountSetDiscountGroupActionQueryBuilderDsl>(p, CartDiscountSetDiscountGroupActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountSetDiscountGroupActionQueryBuilderDsl> DiscountGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountSetDiscountGroupActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupResourceIdentifierQueryBuilderDsl.Of())),
                CartDiscountSetDiscountGroupActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartDiscountSetDiscountGroupActionQueryBuilderDsl, string> SortOrder()
        {
            return new ComparisonPredicateBuilder<CartDiscountSetDiscountGroupActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sortOrder")),
            p => new CombinationQueryPredicate<CartDiscountSetDiscountGroupActionQueryBuilderDsl>(p, CartDiscountSetDiscountGroupActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
