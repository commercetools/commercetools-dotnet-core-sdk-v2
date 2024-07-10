using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductCreatedMessagePayloadQueryBuilderDsl
    {
        public ProductCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductCreatedMessagePayloadQueryBuilderDsl>(p, ProductCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductCreatedMessagePayloadQueryBuilderDsl> ProductProjection(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productProjection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl.Of())),
                ProductCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
