using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartSetDirectDiscountsActionQueryBuilderDsl
    {
        public MyCartSetDirectDiscountsActionQueryBuilderDsl()
        {
        }

        public static MyCartSetDirectDiscountsActionQueryBuilderDsl Of()
        {
            return new MyCartSetDirectDiscountsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartSetDirectDiscountsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartSetDirectDiscountsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartSetDirectDiscountsActionQueryBuilderDsl>(p, MyCartSetDirectDiscountsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCartSetDirectDiscountsActionQueryBuilderDsl> Discounts(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartSetDirectDiscountsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discounts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountDraftQueryBuilderDsl.Of())),
                MyCartSetDirectDiscountsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyCartSetDirectDiscountsActionQueryBuilderDsl> Discounts()
        {
            return new CollectionPredicateBuilder<MyCartSetDirectDiscountsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discounts")),
                    p => new CombinationQueryPredicate<MyCartSetDirectDiscountsActionQueryBuilderDsl>(p, MyCartSetDirectDiscountsActionQueryBuilderDsl.Of));
        }

    }
}
