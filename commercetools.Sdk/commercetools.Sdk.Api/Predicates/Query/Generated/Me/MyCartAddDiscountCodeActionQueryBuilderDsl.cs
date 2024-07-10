using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartAddDiscountCodeActionQueryBuilderDsl
    {
        public MyCartAddDiscountCodeActionQueryBuilderDsl()
        {
        }

        public static MyCartAddDiscountCodeActionQueryBuilderDsl Of()
        {
            return new MyCartAddDiscountCodeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartAddDiscountCodeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartAddDiscountCodeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartAddDiscountCodeActionQueryBuilderDsl>(p, MyCartAddDiscountCodeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartAddDiscountCodeActionQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<MyCartAddDiscountCodeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<MyCartAddDiscountCodeActionQueryBuilderDsl>(p, MyCartAddDiscountCodeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
