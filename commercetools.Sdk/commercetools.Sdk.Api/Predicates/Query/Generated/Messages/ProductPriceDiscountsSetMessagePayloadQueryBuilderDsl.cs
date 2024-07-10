using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl
    {
        public ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl>(p, ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl> UpdatedPrices(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("updatedPrices"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl.Of())),
                ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl> UpdatedPrices()
        {
            return new CollectionPredicateBuilder<ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("updatedPrices")),
                    p => new CombinationQueryPredicate<ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl>(p, ProductPriceDiscountsSetMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
