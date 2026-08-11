// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantChangeAssetOrderActionQueryBuilderDsl
    {
        public VariantChangeAssetOrderActionQueryBuilderDsl()
        {
        }

        public static VariantChangeAssetOrderActionQueryBuilderDsl Of()
        {
            return new VariantChangeAssetOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantChangeAssetOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantChangeAssetOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantChangeAssetOrderActionQueryBuilderDsl>(p, VariantChangeAssetOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantChangeAssetOrderActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantChangeAssetOrderActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantChangeAssetOrderActionQueryBuilderDsl>(p, VariantChangeAssetOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<VariantChangeAssetOrderActionQueryBuilderDsl, string> AssetOrder()
        {
            return new ComparableCollectionPredicateBuilder<VariantChangeAssetOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetOrder")),
            p => new CombinationQueryPredicate<VariantChangeAssetOrderActionQueryBuilderDsl>(p, VariantChangeAssetOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
