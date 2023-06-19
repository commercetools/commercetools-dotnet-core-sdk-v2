using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetMetaTitleActionQueryBuilderDsl
    {
        public ProductSetMetaTitleActionQueryBuilderDsl()
        {
        }

        public static ProductSetMetaTitleActionQueryBuilderDsl Of()
        {
            return new ProductSetMetaTitleActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetMetaTitleActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetMetaTitleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetMetaTitleActionQueryBuilderDsl>(p, ProductSetMetaTitleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSetMetaTitleActionQueryBuilderDsl> MetaTitle(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSetMetaTitleActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaTitle"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductSetMetaTitleActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSetMetaTitleActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetMetaTitleActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetMetaTitleActionQueryBuilderDsl>(p, ProductSetMetaTitleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
