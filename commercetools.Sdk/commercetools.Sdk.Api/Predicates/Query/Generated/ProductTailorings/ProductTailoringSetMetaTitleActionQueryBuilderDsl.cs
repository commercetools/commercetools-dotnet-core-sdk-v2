using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringSetMetaTitleActionQueryBuilderDsl
    {
        public ProductTailoringSetMetaTitleActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringSetMetaTitleActionQueryBuilderDsl Of()
        {
            return new ProductTailoringSetMetaTitleActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringSetMetaTitleActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetMetaTitleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringSetMetaTitleActionQueryBuilderDsl>(p, ProductTailoringSetMetaTitleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringSetMetaTitleActionQueryBuilderDsl> MetaTitle(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringSetMetaTitleActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaTitle"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringSetMetaTitleActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductTailoringSetMetaTitleActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetMetaTitleActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringSetMetaTitleActionQueryBuilderDsl>(p, ProductTailoringSetMetaTitleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
