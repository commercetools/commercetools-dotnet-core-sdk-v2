using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductPagedQueryResponseQueryBuilderDsl
    {
        public ProductPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static ProductPagedQueryResponseQueryBuilderDsl Of()
        {
            return new ProductPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ProductPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ProductPagedQueryResponseQueryBuilderDsl>(p, ProductPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ProductPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ProductPagedQueryResponseQueryBuilderDsl>(p, ProductPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ProductPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ProductPagedQueryResponseQueryBuilderDsl>(p, ProductPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<ProductPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<ProductPagedQueryResponseQueryBuilderDsl>(p, ProductPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductQueryBuilderDsl.Of())),
                ProductPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ProductPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ProductPagedQueryResponseQueryBuilderDsl>(p, ProductPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
