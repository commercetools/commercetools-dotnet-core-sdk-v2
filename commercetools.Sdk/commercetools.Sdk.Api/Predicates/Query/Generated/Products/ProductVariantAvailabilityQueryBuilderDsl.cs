using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductVariantAvailabilityQueryBuilderDsl
    {
        public ProductVariantAvailabilityQueryBuilderDsl()
        {
        }

        public static ProductVariantAvailabilityQueryBuilderDsl Of()
        {
            return new ProductVariantAvailabilityQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductVariantAvailabilityQueryBuilderDsl> Channels(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantChannelAvailabilityMapQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantChannelAvailabilityMapQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantAvailabilityQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantChannelAvailabilityMapQueryBuilderDsl.Of())),
                ProductVariantAvailabilityQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductVariantAvailabilityQueryBuilderDsl, bool> IsOnStock()
        {
            return new ComparisonPredicateBuilder<ProductVariantAvailabilityQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isOnStock")),
            p => new CombinationQueryPredicate<ProductVariantAvailabilityQueryBuilderDsl>(p, ProductVariantAvailabilityQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantAvailabilityQueryBuilderDsl, long> RestockableInDays()
        {
            return new ComparisonPredicateBuilder<ProductVariantAvailabilityQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("restockableInDays")),
            p => new CombinationQueryPredicate<ProductVariantAvailabilityQueryBuilderDsl>(p, ProductVariantAvailabilityQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantAvailabilityQueryBuilderDsl, long> AvailableQuantity()
        {
            return new ComparisonPredicateBuilder<ProductVariantAvailabilityQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("availableQuantity")),
            p => new CombinationQueryPredicate<ProductVariantAvailabilityQueryBuilderDsl>(p, ProductVariantAvailabilityQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantAvailabilityQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductVariantAvailabilityQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductVariantAvailabilityQueryBuilderDsl>(p, ProductVariantAvailabilityQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantAvailabilityQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductVariantAvailabilityQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductVariantAvailabilityQueryBuilderDsl>(p, ProductVariantAvailabilityQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
