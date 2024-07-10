using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartRemoveDiscountCodeActionQueryBuilderDsl
    {
        public MyCartRemoveDiscountCodeActionQueryBuilderDsl()
        {
        }

        public static MyCartRemoveDiscountCodeActionQueryBuilderDsl Of()
        {
            return new MyCartRemoveDiscountCodeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartRemoveDiscountCodeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartRemoveDiscountCodeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartRemoveDiscountCodeActionQueryBuilderDsl>(p, MyCartRemoveDiscountCodeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCartRemoveDiscountCodeActionQueryBuilderDsl> DiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartRemoveDiscountCodeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountCode"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl.Of())),
                MyCartRemoveDiscountCodeActionQueryBuilderDsl.Of);
        }


    }
}
