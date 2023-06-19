using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductRemovePriceActionQueryBuilderDsl
    {
        public ProductRemovePriceActionQueryBuilderDsl()
        {
        }

        public static ProductRemovePriceActionQueryBuilderDsl Of()
        {
            return new ProductRemovePriceActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductRemovePriceActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductRemovePriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductRemovePriceActionQueryBuilderDsl>(p, ProductRemovePriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemovePriceActionQueryBuilderDsl, string> PriceId()
        {
            return new ComparisonPredicateBuilder<ProductRemovePriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceId")),
            p => new CombinationQueryPredicate<ProductRemovePriceActionQueryBuilderDsl>(p, ProductRemovePriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemovePriceActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductRemovePriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductRemovePriceActionQueryBuilderDsl>(p, ProductRemovePriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemovePriceActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductRemovePriceActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductRemovePriceActionQueryBuilderDsl>(p, ProductRemovePriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductRemovePriceActionQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductRemovePriceActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl.Of())),
                ProductRemovePriceActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductRemovePriceActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductRemovePriceActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductRemovePriceActionQueryBuilderDsl>(p, ProductRemovePriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
