// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantSetAssetKeyActionQueryBuilderDsl
    {
        public VariantSetAssetKeyActionQueryBuilderDsl()
        {
        }

        public static VariantSetAssetKeyActionQueryBuilderDsl Of()
        {
            return new VariantSetAssetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantSetAssetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantSetAssetKeyActionQueryBuilderDsl>(p, VariantSetAssetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAssetKeyActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetKeyActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantSetAssetKeyActionQueryBuilderDsl>(p, VariantSetAssetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAssetKeyActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<VariantSetAssetKeyActionQueryBuilderDsl>(p, VariantSetAssetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAssetKeyActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<VariantSetAssetKeyActionQueryBuilderDsl>(p, VariantSetAssetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
