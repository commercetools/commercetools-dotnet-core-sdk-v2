// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringMoveImageToPositionActionQueryBuilderDsl
    {
        public ProductTailoringMoveImageToPositionActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringMoveImageToPositionActionQueryBuilderDsl Of()
        {
            return new ProductTailoringMoveImageToPositionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringMoveImageToPositionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringMoveImageToPositionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringMoveImageToPositionActionQueryBuilderDsl>(p, ProductTailoringMoveImageToPositionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringMoveImageToPositionActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringMoveImageToPositionActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductTailoringMoveImageToPositionActionQueryBuilderDsl>(p, ProductTailoringMoveImageToPositionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringMoveImageToPositionActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductTailoringMoveImageToPositionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductTailoringMoveImageToPositionActionQueryBuilderDsl>(p, ProductTailoringMoveImageToPositionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringMoveImageToPositionActionQueryBuilderDsl, string> ImageUrl()
        {
            return new ComparisonPredicateBuilder<ProductTailoringMoveImageToPositionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("imageUrl")),
            p => new CombinationQueryPredicate<ProductTailoringMoveImageToPositionActionQueryBuilderDsl>(p, ProductTailoringMoveImageToPositionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringMoveImageToPositionActionQueryBuilderDsl, long> Position()
        {
            return new ComparisonPredicateBuilder<ProductTailoringMoveImageToPositionActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("position")),
            p => new CombinationQueryPredicate<ProductTailoringMoveImageToPositionActionQueryBuilderDsl>(p, ProductTailoringMoveImageToPositionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringMoveImageToPositionActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringMoveImageToPositionActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringMoveImageToPositionActionQueryBuilderDsl>(p, ProductTailoringMoveImageToPositionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
