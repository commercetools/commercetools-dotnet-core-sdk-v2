using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryRemoveAssetActionQueryBuilderDsl
    {
        public CategoryRemoveAssetActionQueryBuilderDsl()
        {
        }

        public static CategoryRemoveAssetActionQueryBuilderDsl Of()
        {
            return new CategoryRemoveAssetActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryRemoveAssetActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategoryRemoveAssetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategoryRemoveAssetActionQueryBuilderDsl>(p, CategoryRemoveAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategoryRemoveAssetActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<CategoryRemoveAssetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<CategoryRemoveAssetActionQueryBuilderDsl>(p, CategoryRemoveAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategoryRemoveAssetActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<CategoryRemoveAssetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<CategoryRemoveAssetActionQueryBuilderDsl>(p, CategoryRemoveAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
