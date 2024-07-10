using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductAddPriceActionQueryBuilderDsl
    {
        public ProductAddPriceActionQueryBuilderDsl()
        {
        }

        public static ProductAddPriceActionQueryBuilderDsl Of()
        {
            return new ProductAddPriceActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductAddPriceActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductAddPriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductAddPriceActionQueryBuilderDsl>(p, ProductAddPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductAddPriceActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductAddPriceActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductAddPriceActionQueryBuilderDsl>(p, ProductAddPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductAddPriceActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductAddPriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductAddPriceActionQueryBuilderDsl>(p, ProductAddPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductAddPriceActionQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductAddPriceActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl.Of())),
                ProductAddPriceActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductAddPriceActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductAddPriceActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductAddPriceActionQueryBuilderDsl>(p, ProductAddPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
