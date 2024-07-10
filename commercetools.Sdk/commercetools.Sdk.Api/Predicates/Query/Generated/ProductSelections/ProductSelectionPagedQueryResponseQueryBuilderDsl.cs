using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductSelectionPagedQueryResponseQueryBuilderDsl
    {
        public ProductSelectionPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static ProductSelectionPagedQueryResponseQueryBuilderDsl Of()
        {
            return new ProductSelectionPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSelectionPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ProductSelectionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ProductSelectionPagedQueryResponseQueryBuilderDsl>(p, ProductSelectionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSelectionPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ProductSelectionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ProductSelectionPagedQueryResponseQueryBuilderDsl>(p, ProductSelectionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSelectionPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ProductSelectionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ProductSelectionPagedQueryResponseQueryBuilderDsl>(p, ProductSelectionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSelectionPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<ProductSelectionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<ProductSelectionPagedQueryResponseQueryBuilderDsl>(p, ProductSelectionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSelectionPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionQueryBuilderDsl.Of())),
                ProductSelectionPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSelectionPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ProductSelectionPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ProductSelectionPagedQueryResponseQueryBuilderDsl>(p, ProductSelectionPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
