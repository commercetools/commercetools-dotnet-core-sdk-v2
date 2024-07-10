using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductMoveImageToPositionActionQueryBuilderDsl
    {
        public ProductMoveImageToPositionActionQueryBuilderDsl()
        {
        }

        public static ProductMoveImageToPositionActionQueryBuilderDsl Of()
        {
            return new ProductMoveImageToPositionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductMoveImageToPositionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductMoveImageToPositionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductMoveImageToPositionActionQueryBuilderDsl>(p, ProductMoveImageToPositionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductMoveImageToPositionActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductMoveImageToPositionActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductMoveImageToPositionActionQueryBuilderDsl>(p, ProductMoveImageToPositionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductMoveImageToPositionActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductMoveImageToPositionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductMoveImageToPositionActionQueryBuilderDsl>(p, ProductMoveImageToPositionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductMoveImageToPositionActionQueryBuilderDsl, string> ImageUrl()
        {
            return new ComparisonPredicateBuilder<ProductMoveImageToPositionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("imageUrl")),
            p => new CombinationQueryPredicate<ProductMoveImageToPositionActionQueryBuilderDsl>(p, ProductMoveImageToPositionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductMoveImageToPositionActionQueryBuilderDsl, long> Position()
        {
            return new ComparisonPredicateBuilder<ProductMoveImageToPositionActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("position")),
            p => new CombinationQueryPredicate<ProductMoveImageToPositionActionQueryBuilderDsl>(p, ProductMoveImageToPositionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductMoveImageToPositionActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductMoveImageToPositionActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductMoveImageToPositionActionQueryBuilderDsl>(p, ProductMoveImageToPositionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
