using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductUpdateQueryBuilderDsl
    {
        public ProductUpdateQueryBuilderDsl()
        {
        }

        public static ProductUpdateQueryBuilderDsl Of()
        {
            return new ProductUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductUpdateQueryBuilderDsl>(p, ProductUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductUpdateActionQueryBuilderDsl.Of())),
                ProductUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<ProductUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<ProductUpdateQueryBuilderDsl>(p, ProductUpdateQueryBuilderDsl.Of));
        }

    }
}
