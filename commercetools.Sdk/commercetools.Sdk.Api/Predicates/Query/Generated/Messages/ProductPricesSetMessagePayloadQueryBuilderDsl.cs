using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductPricesSetMessagePayloadQueryBuilderDsl
    {
        public ProductPricesSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductPricesSetMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductPricesSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPricesSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductPricesSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductPricesSetMessagePayloadQueryBuilderDsl>(p, ProductPricesSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPricesSetMessagePayloadQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductPricesSetMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductPricesSetMessagePayloadQueryBuilderDsl>(p, ProductPricesSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPricesSetMessagePayloadQueryBuilderDsl> Prices(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPricesSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("prices"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl.Of())),
                ProductPricesSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductPricesSetMessagePayloadQueryBuilderDsl> Prices()
        {
            return new CollectionPredicateBuilder<ProductPricesSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("prices")),
                    p => new CombinationQueryPredicate<ProductPricesSetMessagePayloadQueryBuilderDsl>(p, ProductPricesSetMessagePayloadQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ProductPricesSetMessagePayloadQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductPricesSetMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductPricesSetMessagePayloadQueryBuilderDsl>(p, ProductPricesSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
