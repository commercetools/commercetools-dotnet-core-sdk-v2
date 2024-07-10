using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypePagedQueryResponseQueryBuilderDsl
    {
        public ProductTypePagedQueryResponseQueryBuilderDsl()
        {
        }

        public static ProductTypePagedQueryResponseQueryBuilderDsl Of()
        {
            return new ProductTypePagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypePagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ProductTypePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ProductTypePagedQueryResponseQueryBuilderDsl>(p, ProductTypePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypePagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ProductTypePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ProductTypePagedQueryResponseQueryBuilderDsl>(p, ProductTypePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypePagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ProductTypePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ProductTypePagedQueryResponseQueryBuilderDsl>(p, ProductTypePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypePagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<ProductTypePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<ProductTypePagedQueryResponseQueryBuilderDsl>(p, ProductTypePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTypePagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypePagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeQueryBuilderDsl.Of())),
                ProductTypePagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductTypePagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ProductTypePagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ProductTypePagedQueryResponseQueryBuilderDsl>(p, ProductTypePagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
