using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartChangeCustomLineItemMoneyActionQueryBuilderDsl
    {
        public CartChangeCustomLineItemMoneyActionQueryBuilderDsl()
        {
        }

        public static CartChangeCustomLineItemMoneyActionQueryBuilderDsl Of()
        {
            return new CartChangeCustomLineItemMoneyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartChangeCustomLineItemMoneyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartChangeCustomLineItemMoneyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartChangeCustomLineItemMoneyActionQueryBuilderDsl>(p, CartChangeCustomLineItemMoneyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartChangeCustomLineItemMoneyActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<CartChangeCustomLineItemMoneyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<CartChangeCustomLineItemMoneyActionQueryBuilderDsl>(p, CartChangeCustomLineItemMoneyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartChangeCustomLineItemMoneyActionQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<CartChangeCustomLineItemMoneyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<CartChangeCustomLineItemMoneyActionQueryBuilderDsl>(p, CartChangeCustomLineItemMoneyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartChangeCustomLineItemMoneyActionQueryBuilderDsl> Money(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartChangeCustomLineItemMoneyActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("money"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                CartChangeCustomLineItemMoneyActionQueryBuilderDsl.Of);
        }


    }
}
