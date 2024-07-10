using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountReferenceQueryBuilderDsl
    {
        public CartDiscountReferenceQueryBuilderDsl()
        {
        }

        public static CartDiscountReferenceQueryBuilderDsl Of()
        {
            return new CartDiscountReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<CartDiscountReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<CartDiscountReferenceQueryBuilderDsl>(p, CartDiscountReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CartDiscountReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CartDiscountReferenceQueryBuilderDsl>(p, CartDiscountReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountQueryBuilderDsl.Of())),
                CartDiscountReferenceQueryBuilderDsl.Of);
        }


    }
}
