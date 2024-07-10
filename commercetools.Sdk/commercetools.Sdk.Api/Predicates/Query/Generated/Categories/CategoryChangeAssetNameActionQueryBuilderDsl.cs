using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryChangeAssetNameActionQueryBuilderDsl
    {
        public CategoryChangeAssetNameActionQueryBuilderDsl()
        {
        }

        public static CategoryChangeAssetNameActionQueryBuilderDsl Of()
        {
            return new CategoryChangeAssetNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryChangeAssetNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategoryChangeAssetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategoryChangeAssetNameActionQueryBuilderDsl>(p, CategoryChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategoryChangeAssetNameActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<CategoryChangeAssetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<CategoryChangeAssetNameActionQueryBuilderDsl>(p, CategoryChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategoryChangeAssetNameActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<CategoryChangeAssetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<CategoryChangeAssetNameActionQueryBuilderDsl>(p, CategoryChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategoryChangeAssetNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryChangeAssetNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CategoryChangeAssetNameActionQueryBuilderDsl.Of);
        }


    }
}
