using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountValueFixedDraftQueryBuilderDsl
    {
        public CartDiscountValueFixedDraftQueryBuilderDsl()
        {
        }

        public static CartDiscountValueFixedDraftQueryBuilderDsl Of()
        {
            return new CartDiscountValueFixedDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountValueFixedDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueFixedDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountValueFixedDraftQueryBuilderDsl>(p, CartDiscountValueFixedDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountValueFixedDraftQueryBuilderDsl> Money(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueFixedDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("money"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                CartDiscountValueFixedDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDiscountValueFixedDraftQueryBuilderDsl> Money()
        {
            return new CollectionPredicateBuilder<CartDiscountValueFixedDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("money")),
                    p => new CombinationQueryPredicate<CartDiscountValueFixedDraftQueryBuilderDsl>(p, CartDiscountValueFixedDraftQueryBuilderDsl.Of));
        }

    }
}
