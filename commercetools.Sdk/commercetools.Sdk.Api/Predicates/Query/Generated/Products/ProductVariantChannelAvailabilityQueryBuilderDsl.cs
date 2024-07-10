using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductVariantChannelAvailabilityQueryBuilderDsl
    {
        public ProductVariantChannelAvailabilityQueryBuilderDsl()
        {
        }

        public static ProductVariantChannelAvailabilityQueryBuilderDsl Of()
        {
            return new ProductVariantChannelAvailabilityQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductVariantChannelAvailabilityQueryBuilderDsl, bool> IsOnStock()
        {
            return new ComparisonPredicateBuilder<ProductVariantChannelAvailabilityQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isOnStock")),
            p => new CombinationQueryPredicate<ProductVariantChannelAvailabilityQueryBuilderDsl>(p, ProductVariantChannelAvailabilityQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantChannelAvailabilityQueryBuilderDsl, long> RestockableInDays()
        {
            return new ComparisonPredicateBuilder<ProductVariantChannelAvailabilityQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("restockableInDays")),
            p => new CombinationQueryPredicate<ProductVariantChannelAvailabilityQueryBuilderDsl>(p, ProductVariantChannelAvailabilityQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantChannelAvailabilityQueryBuilderDsl, long> AvailableQuantity()
        {
            return new ComparisonPredicateBuilder<ProductVariantChannelAvailabilityQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("availableQuantity")),
            p => new CombinationQueryPredicate<ProductVariantChannelAvailabilityQueryBuilderDsl>(p, ProductVariantChannelAvailabilityQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantChannelAvailabilityQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductVariantChannelAvailabilityQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductVariantChannelAvailabilityQueryBuilderDsl>(p, ProductVariantChannelAvailabilityQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantChannelAvailabilityQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductVariantChannelAvailabilityQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductVariantChannelAvailabilityQueryBuilderDsl>(p, ProductVariantChannelAvailabilityQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
