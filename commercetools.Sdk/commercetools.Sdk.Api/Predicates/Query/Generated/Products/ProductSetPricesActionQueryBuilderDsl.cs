using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetPricesActionQueryBuilderDsl
    {
        public ProductSetPricesActionQueryBuilderDsl()
        {
        }

        public static ProductSetPricesActionQueryBuilderDsl Of()
        {
            return new ProductSetPricesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetPricesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetPricesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetPricesActionQueryBuilderDsl>(p, ProductSetPricesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetPricesActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductSetPricesActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductSetPricesActionQueryBuilderDsl>(p, ProductSetPricesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetPricesActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductSetPricesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductSetPricesActionQueryBuilderDsl>(p, ProductSetPricesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSetPricesActionQueryBuilderDsl> Prices(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSetPricesActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("prices"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl.Of())),
                ProductSetPricesActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSetPricesActionQueryBuilderDsl> Prices()
        {
            return new CollectionPredicateBuilder<ProductSetPricesActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("prices")),
                    p => new CombinationQueryPredicate<ProductSetPricesActionQueryBuilderDsl>(p, ProductSetPricesActionQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ProductSetPricesActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetPricesActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetPricesActionQueryBuilderDsl>(p, ProductSetPricesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
