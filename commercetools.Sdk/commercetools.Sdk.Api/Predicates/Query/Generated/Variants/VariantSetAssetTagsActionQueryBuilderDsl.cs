// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantSetAssetTagsActionQueryBuilderDsl
    {
        public VariantSetAssetTagsActionQueryBuilderDsl()
        {
        }

        public static VariantSetAssetTagsActionQueryBuilderDsl Of()
        {
            return new VariantSetAssetTagsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantSetAssetTagsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantSetAssetTagsActionQueryBuilderDsl>(p, VariantSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAssetTagsActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetTagsActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantSetAssetTagsActionQueryBuilderDsl>(p, VariantSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAssetTagsActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<VariantSetAssetTagsActionQueryBuilderDsl>(p, VariantSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAssetTagsActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<VariantSetAssetTagsActionQueryBuilderDsl>(p, VariantSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<VariantSetAssetTagsActionQueryBuilderDsl, string> Tags()
        {
            return new ComparableCollectionPredicateBuilder<VariantSetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tags")),
            p => new CombinationQueryPredicate<VariantSetAssetTagsActionQueryBuilderDsl>(p, VariantSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
