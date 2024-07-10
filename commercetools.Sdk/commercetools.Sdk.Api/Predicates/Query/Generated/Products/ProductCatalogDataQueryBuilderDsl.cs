using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductCatalogDataQueryBuilderDsl
    {
        public ProductCatalogDataQueryBuilderDsl()
        {
        }

        public static ProductCatalogDataQueryBuilderDsl Of()
        {
            return new ProductCatalogDataQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductCatalogDataQueryBuilderDsl, bool> Published()
        {
            return new ComparisonPredicateBuilder<ProductCatalogDataQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("published")),
            p => new CombinationQueryPredicate<ProductCatalogDataQueryBuilderDsl>(p, ProductCatalogDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductCatalogDataQueryBuilderDsl> Current(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductCatalogDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("current"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductDataQueryBuilderDsl.Of())),
                ProductCatalogDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductCatalogDataQueryBuilderDsl> Staged(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductCatalogDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("staged"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductDataQueryBuilderDsl.Of())),
                ProductCatalogDataQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductCatalogDataQueryBuilderDsl, bool> HasStagedChanges()
        {
            return new ComparisonPredicateBuilder<ProductCatalogDataQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("hasStagedChanges")),
            p => new CombinationQueryPredicate<ProductCatalogDataQueryBuilderDsl>(p, ProductCatalogDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
