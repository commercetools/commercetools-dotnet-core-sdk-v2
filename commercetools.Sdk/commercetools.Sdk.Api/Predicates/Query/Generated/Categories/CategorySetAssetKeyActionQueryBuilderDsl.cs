// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategorySetAssetKeyActionQueryBuilderDsl
    {
        public CategorySetAssetKeyActionQueryBuilderDsl()
        {
        }

        public static CategorySetAssetKeyActionQueryBuilderDsl Of()
        {
            return new CategorySetAssetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategorySetAssetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategorySetAssetKeyActionQueryBuilderDsl>(p, CategorySetAssetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategorySetAssetKeyActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<CategorySetAssetKeyActionQueryBuilderDsl>(p, CategorySetAssetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategorySetAssetKeyActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<CategorySetAssetKeyActionQueryBuilderDsl>(p, CategorySetAssetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
