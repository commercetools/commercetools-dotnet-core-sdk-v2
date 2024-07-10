using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetDiscountedPriceActionQueryBuilderDsl
    {
        public ProductSetDiscountedPriceActionQueryBuilderDsl()
        {
        }

        public static ProductSetDiscountedPriceActionQueryBuilderDsl Of()
        {
            return new ProductSetDiscountedPriceActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetDiscountedPriceActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetDiscountedPriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetDiscountedPriceActionQueryBuilderDsl>(p, ProductSetDiscountedPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetDiscountedPriceActionQueryBuilderDsl, string> PriceId()
        {
            return new ComparisonPredicateBuilder<ProductSetDiscountedPriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceId")),
            p => new CombinationQueryPredicate<ProductSetDiscountedPriceActionQueryBuilderDsl>(p, ProductSetDiscountedPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetDiscountedPriceActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetDiscountedPriceActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetDiscountedPriceActionQueryBuilderDsl>(p, ProductSetDiscountedPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSetDiscountedPriceActionQueryBuilderDsl> Discounted(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSetDiscountedPriceActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discounted"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceDraftQueryBuilderDsl.Of())),
                ProductSetDiscountedPriceActionQueryBuilderDsl.Of);
        }


    }
}
