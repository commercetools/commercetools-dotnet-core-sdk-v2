using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductProjectionPagedQueryResponseQueryBuilderDsl
    {
        public ProductProjectionPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static ProductProjectionPagedQueryResponseQueryBuilderDsl Of()
        {
            return new ProductProjectionPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductProjectionPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ProductProjectionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ProductProjectionPagedQueryResponseQueryBuilderDsl>(p, ProductProjectionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductProjectionPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ProductProjectionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ProductProjectionPagedQueryResponseQueryBuilderDsl>(p, ProductProjectionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductProjectionPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<ProductProjectionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<ProductProjectionPagedQueryResponseQueryBuilderDsl>(p, ProductProjectionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductProjectionPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ProductProjectionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ProductProjectionPagedQueryResponseQueryBuilderDsl>(p, ProductProjectionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductProjectionPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl.Of())),
                ProductProjectionPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductProjectionPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ProductProjectionPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ProductProjectionPagedQueryResponseQueryBuilderDsl>(p, ProductProjectionPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
