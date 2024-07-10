using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartReferenceQueryBuilderDsl
    {
        public CartReferenceQueryBuilderDsl()
        {
        }

        public static CartReferenceQueryBuilderDsl Of()
        {
            return new CartReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<CartReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<CartReferenceQueryBuilderDsl>(p, CartReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CartReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CartReferenceQueryBuilderDsl>(p, CartReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartQueryBuilderDsl.Of())),
                CartReferenceQueryBuilderDsl.Of);
        }


    }
}
