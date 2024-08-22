using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountValueAbsoluteQueryBuilderDsl
    {
        public CartDiscountValueAbsoluteQueryBuilderDsl()
        {
        }

        public static CartDiscountValueAbsoluteQueryBuilderDsl Of()
        {
            return new CartDiscountValueAbsoluteQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountValueAbsoluteQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueAbsoluteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountValueAbsoluteQueryBuilderDsl>(p, CartDiscountValueAbsoluteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountValueAbsoluteQueryBuilderDsl> Money(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueAbsoluteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("money"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                CartDiscountValueAbsoluteQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDiscountValueAbsoluteQueryBuilderDsl> Money()
        {
            return new CollectionPredicateBuilder<CartDiscountValueAbsoluteQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("money")),
                    p => new CombinationQueryPredicate<CartDiscountValueAbsoluteQueryBuilderDsl>(p, CartDiscountValueAbsoluteQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<CartDiscountValueAbsoluteQueryBuilderDsl, string> ApplicationMode()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueAbsoluteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("applicationMode")),
            p => new CombinationQueryPredicate<CartDiscountValueAbsoluteQueryBuilderDsl>(p, CartDiscountValueAbsoluteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
