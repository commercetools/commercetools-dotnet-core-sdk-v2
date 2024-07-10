using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductPriceChangedMessagePayloadQueryBuilderDsl
    {
        public ProductPriceChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductPriceChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductPriceChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPriceChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductPriceChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductPriceChangedMessagePayloadQueryBuilderDsl>(p, ProductPriceChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceChangedMessagePayloadQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductPriceChangedMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductPriceChangedMessagePayloadQueryBuilderDsl>(p, ProductPriceChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPriceChangedMessagePayloadQueryBuilderDsl> OldPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPriceChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl.Of())),
                ProductPriceChangedMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductPriceChangedMessagePayloadQueryBuilderDsl> NewPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPriceChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("newPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl.Of())),
                ProductPriceChangedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductPriceChangedMessagePayloadQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductPriceChangedMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductPriceChangedMessagePayloadQueryBuilderDsl>(p, ProductPriceChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPriceChangedMessagePayloadQueryBuilderDsl> OldStagedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPriceChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldStagedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl.Of())),
                ProductPriceChangedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
