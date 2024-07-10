using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountValueAbsoluteDraftQueryBuilderDsl
    {
        public CartDiscountValueAbsoluteDraftQueryBuilderDsl()
        {
        }

        public static CartDiscountValueAbsoluteDraftQueryBuilderDsl Of()
        {
            return new CartDiscountValueAbsoluteDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountValueAbsoluteDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueAbsoluteDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountValueAbsoluteDraftQueryBuilderDsl>(p, CartDiscountValueAbsoluteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountValueAbsoluteDraftQueryBuilderDsl> Money(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountValueAbsoluteDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("money"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                CartDiscountValueAbsoluteDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDiscountValueAbsoluteDraftQueryBuilderDsl> Money()
        {
            return new CollectionPredicateBuilder<CartDiscountValueAbsoluteDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("money")),
                    p => new CombinationQueryPredicate<CartDiscountValueAbsoluteDraftQueryBuilderDsl>(p, CartDiscountValueAbsoluteDraftQueryBuilderDsl.Of));
        }

    }
}
