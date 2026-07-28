// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantMoveImageToPositionActionQueryBuilderDsl
    {
        public VariantMoveImageToPositionActionQueryBuilderDsl()
        {
        }

        public static VariantMoveImageToPositionActionQueryBuilderDsl Of()
        {
            return new VariantMoveImageToPositionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantMoveImageToPositionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantMoveImageToPositionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantMoveImageToPositionActionQueryBuilderDsl>(p, VariantMoveImageToPositionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantMoveImageToPositionActionQueryBuilderDsl, string> ImageUrl()
        {
            return new ComparisonPredicateBuilder<VariantMoveImageToPositionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("imageUrl")),
            p => new CombinationQueryPredicate<VariantMoveImageToPositionActionQueryBuilderDsl>(p, VariantMoveImageToPositionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantMoveImageToPositionActionQueryBuilderDsl, long> Position()
        {
            return new ComparisonPredicateBuilder<VariantMoveImageToPositionActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("position")),
            p => new CombinationQueryPredicate<VariantMoveImageToPositionActionQueryBuilderDsl>(p, VariantMoveImageToPositionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantMoveImageToPositionActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantMoveImageToPositionActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantMoveImageToPositionActionQueryBuilderDsl>(p, VariantMoveImageToPositionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
