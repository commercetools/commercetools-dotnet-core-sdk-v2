using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductPriceRemovedMessagePayloadQueryBuilderDsl
    {
        public ProductPriceRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductPriceRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductPriceRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPriceRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductPriceRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductPriceRemovedMessagePayloadQueryBuilderDsl>(p, ProductPriceRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceRemovedMessagePayloadQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductPriceRemovedMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductPriceRemovedMessagePayloadQueryBuilderDsl>(p, ProductPriceRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPriceRemovedMessagePayloadQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPriceRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl.Of())),
                ProductPriceRemovedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductPriceRemovedMessagePayloadQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductPriceRemovedMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductPriceRemovedMessagePayloadQueryBuilderDsl>(p, ProductPriceRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
