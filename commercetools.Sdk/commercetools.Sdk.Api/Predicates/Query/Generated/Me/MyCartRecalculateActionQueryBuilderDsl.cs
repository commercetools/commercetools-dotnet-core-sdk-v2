using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartRecalculateActionQueryBuilderDsl
    {
        public MyCartRecalculateActionQueryBuilderDsl()
        {
        }

        public static MyCartRecalculateActionQueryBuilderDsl Of()
        {
            return new MyCartRecalculateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartRecalculateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartRecalculateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartRecalculateActionQueryBuilderDsl>(p, MyCartRecalculateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartRecalculateActionQueryBuilderDsl, bool> UpdateProductData()
        {
            return new ComparisonPredicateBuilder<MyCartRecalculateActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("updateProductData")),
            p => new CombinationQueryPredicate<MyCartRecalculateActionQueryBuilderDsl>(p, MyCartRecalculateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
