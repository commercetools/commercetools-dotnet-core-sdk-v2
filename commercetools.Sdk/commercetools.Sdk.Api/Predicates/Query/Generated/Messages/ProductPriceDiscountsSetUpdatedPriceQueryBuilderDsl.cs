using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl
    {
        public ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl()
        {
        }

        public static ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl Of()
        {
            return new ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl>(p, ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl, string> VariantKey()
        {
            return new ComparisonPredicateBuilder<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantKey")),
            p => new CombinationQueryPredicate<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl>(p, ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl>(p, ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl, string> PriceId()
        {
            return new ComparisonPredicateBuilder<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceId")),
            p => new CombinationQueryPredicate<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl>(p, ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl> Discounted(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discounted"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceQueryBuilderDsl.Of())),
                ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl>(p, ProductPriceDiscountsSetUpdatedPriceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
