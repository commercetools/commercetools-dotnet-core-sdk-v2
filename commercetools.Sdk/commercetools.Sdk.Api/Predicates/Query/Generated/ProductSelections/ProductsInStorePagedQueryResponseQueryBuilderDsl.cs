using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductsInStorePagedQueryResponseQueryBuilderDsl
    {
        public ProductsInStorePagedQueryResponseQueryBuilderDsl()
        {
        }

        public static ProductsInStorePagedQueryResponseQueryBuilderDsl Of()
        {
            return new ProductsInStorePagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductsInStorePagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ProductsInStorePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ProductsInStorePagedQueryResponseQueryBuilderDsl>(p, ProductsInStorePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductsInStorePagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ProductsInStorePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ProductsInStorePagedQueryResponseQueryBuilderDsl>(p, ProductsInStorePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductsInStorePagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ProductsInStorePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ProductsInStorePagedQueryResponseQueryBuilderDsl>(p, ProductsInStorePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductsInStorePagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<ProductsInStorePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<ProductsInStorePagedQueryResponseQueryBuilderDsl>(p, ProductsInStorePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductsInStorePagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionAssignmentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionAssignmentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductsInStorePagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionAssignmentQueryBuilderDsl.Of())),
                ProductsInStorePagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductsInStorePagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ProductsInStorePagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ProductsInStorePagedQueryResponseQueryBuilderDsl>(p, ProductsInStorePagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
