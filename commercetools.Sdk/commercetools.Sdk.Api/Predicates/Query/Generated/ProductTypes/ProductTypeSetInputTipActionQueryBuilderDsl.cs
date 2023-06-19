using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeSetInputTipActionQueryBuilderDsl
    {
        public ProductTypeSetInputTipActionQueryBuilderDsl()
        {
        }

        public static ProductTypeSetInputTipActionQueryBuilderDsl Of()
        {
            return new ProductTypeSetInputTipActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeSetInputTipActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeSetInputTipActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeSetInputTipActionQueryBuilderDsl>(p, ProductTypeSetInputTipActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeSetInputTipActionQueryBuilderDsl, string> AttributeName()
        {
            return new ComparisonPredicateBuilder<ProductTypeSetInputTipActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeName")),
            p => new CombinationQueryPredicate<ProductTypeSetInputTipActionQueryBuilderDsl>(p, ProductTypeSetInputTipActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTypeSetInputTipActionQueryBuilderDsl> InputTip(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeSetInputTipActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("inputTip"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTypeSetInputTipActionQueryBuilderDsl.Of);
        }


    }
}
