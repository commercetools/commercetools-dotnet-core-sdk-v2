using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchErrorResponseQueryBuilderDsl
    {
        public ProductSearchErrorResponseQueryBuilderDsl()
        {
        }

        public static ProductSearchErrorResponseQueryBuilderDsl Of()
        {
            return new ProductSearchErrorResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchErrorResponseQueryBuilderDsl, long> StatusCode()
        {
            return new ComparisonPredicateBuilder<ProductSearchErrorResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("statusCode")),
            p => new CombinationQueryPredicate<ProductSearchErrorResponseQueryBuilderDsl>(p, ProductSearchErrorResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchErrorResponseQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ProductSearchErrorResponseQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ProductSearchErrorResponseQueryBuilderDsl>(p, ProductSearchErrorResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSearchErrorResponseQueryBuilderDsl> Errors(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchErrorResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("errors"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl.Of())),
                ProductSearchErrorResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSearchErrorResponseQueryBuilderDsl> Errors()
        {
            return new CollectionPredicateBuilder<ProductSearchErrorResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("errors")),
                    p => new CombinationQueryPredicate<ProductSearchErrorResponseQueryBuilderDsl>(p, ProductSearchErrorResponseQueryBuilderDsl.Of));
        }

    }
}
