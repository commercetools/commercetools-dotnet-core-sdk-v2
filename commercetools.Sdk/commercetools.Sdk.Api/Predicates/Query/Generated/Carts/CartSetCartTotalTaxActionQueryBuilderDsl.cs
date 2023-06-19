using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetCartTotalTaxActionQueryBuilderDsl
    {
        public CartSetCartTotalTaxActionQueryBuilderDsl()
        {
        }

        public static CartSetCartTotalTaxActionQueryBuilderDsl Of()
        {
            return new CartSetCartTotalTaxActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetCartTotalTaxActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetCartTotalTaxActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetCartTotalTaxActionQueryBuilderDsl>(p, CartSetCartTotalTaxActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetCartTotalTaxActionQueryBuilderDsl> ExternalTotalGross(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetCartTotalTaxActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTotalGross"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                CartSetCartTotalTaxActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartSetCartTotalTaxActionQueryBuilderDsl> ExternalTaxPortions(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxPortionDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxPortionDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetCartTotalTaxActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxPortions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxPortionDraftQueryBuilderDsl.Of())),
                CartSetCartTotalTaxActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartSetCartTotalTaxActionQueryBuilderDsl> ExternalTaxPortions()
        {
            return new CollectionPredicateBuilder<CartSetCartTotalTaxActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalTaxPortions")),
                    p => new CombinationQueryPredicate<CartSetCartTotalTaxActionQueryBuilderDsl>(p, CartSetCartTotalTaxActionQueryBuilderDsl.Of));
        }

    }
}
