using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountValueFixedQueryBuilderDsl
    {
        public CartDiscountValueFixedQueryBuilderDsl()
        {
        }

        public static CartDiscountValueFixedQueryBuilderDsl Of()
        {
            return new CartDiscountValueFixedQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountValueFixedQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueFixedQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountValueFixedQueryBuilderDsl>(p, CartDiscountValueFixedQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountValueFixedQueryBuilderDsl> Money(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueFixedQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("money"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl.Of())),
                CartDiscountValueFixedQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDiscountValueFixedQueryBuilderDsl> Money()
        {
            return new CollectionPredicateBuilder<CartDiscountValueFixedQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("money")),
                    p => new CombinationQueryPredicate<CartDiscountValueFixedQueryBuilderDsl>(p, CartDiscountValueFixedQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<CartDiscountValueFixedQueryBuilderDsl, string> ApplicationMode()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueFixedQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("applicationMode")),
            p => new CombinationQueryPredicate<CartDiscountValueFixedQueryBuilderDsl>(p, CartDiscountValueFixedQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
