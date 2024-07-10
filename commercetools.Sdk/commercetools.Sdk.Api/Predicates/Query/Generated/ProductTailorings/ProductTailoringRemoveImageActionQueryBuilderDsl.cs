using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringRemoveImageActionQueryBuilderDsl
    {
        public ProductTailoringRemoveImageActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringRemoveImageActionQueryBuilderDsl Of()
        {
            return new ProductTailoringRemoveImageActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringRemoveImageActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringRemoveImageActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringRemoveImageActionQueryBuilderDsl>(p, ProductTailoringRemoveImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringRemoveImageActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringRemoveImageActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductTailoringRemoveImageActionQueryBuilderDsl>(p, ProductTailoringRemoveImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringRemoveImageActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductTailoringRemoveImageActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductTailoringRemoveImageActionQueryBuilderDsl>(p, ProductTailoringRemoveImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringRemoveImageActionQueryBuilderDsl, string> ImageUrl()
        {
            return new ComparisonPredicateBuilder<ProductTailoringRemoveImageActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("imageUrl")),
            p => new CombinationQueryPredicate<ProductTailoringRemoveImageActionQueryBuilderDsl>(p, ProductTailoringRemoveImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringRemoveImageActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringRemoveImageActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringRemoveImageActionQueryBuilderDsl>(p, ProductTailoringRemoveImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
