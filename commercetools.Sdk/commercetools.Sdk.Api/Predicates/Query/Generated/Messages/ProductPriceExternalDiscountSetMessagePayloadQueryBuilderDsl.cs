using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl
    {
        public ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl>(p, ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl>(p, ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl, string> VariantKey()
        {
            return new ComparisonPredicateBuilder<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantKey")),
            p => new CombinationQueryPredicate<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl>(p, ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl>(p, ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl, string> PriceId()
        {
            return new ComparisonPredicateBuilder<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceId")),
            p => new CombinationQueryPredicate<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl>(p, ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl> Discounted(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discounted"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceQueryBuilderDsl.Of())),
                ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl>(p, ProductPriceExternalDiscountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
