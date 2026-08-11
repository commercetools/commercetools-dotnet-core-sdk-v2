// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantRemoveAssetActionQueryBuilderDsl
    {
        public VariantRemoveAssetActionQueryBuilderDsl()
        {
        }

        public static VariantRemoveAssetActionQueryBuilderDsl Of()
        {
            return new VariantRemoveAssetActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantRemoveAssetActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantRemoveAssetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantRemoveAssetActionQueryBuilderDsl>(p, VariantRemoveAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantRemoveAssetActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantRemoveAssetActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantRemoveAssetActionQueryBuilderDsl>(p, VariantRemoveAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantRemoveAssetActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<VariantRemoveAssetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<VariantRemoveAssetActionQueryBuilderDsl>(p, VariantRemoveAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantRemoveAssetActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<VariantRemoveAssetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<VariantRemoveAssetActionQueryBuilderDsl>(p, VariantRemoveAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
