using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategorySetAssetDescriptionActionQueryBuilderDsl
    {
        public CategorySetAssetDescriptionActionQueryBuilderDsl()
        {
        }

        public static CategorySetAssetDescriptionActionQueryBuilderDsl Of()
        {
            return new CategorySetAssetDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategorySetAssetDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategorySetAssetDescriptionActionQueryBuilderDsl>(p, CategorySetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategorySetAssetDescriptionActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<CategorySetAssetDescriptionActionQueryBuilderDsl>(p, CategorySetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategorySetAssetDescriptionActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<CategorySetAssetDescriptionActionQueryBuilderDsl>(p, CategorySetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategorySetAssetDescriptionActionQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategorySetAssetDescriptionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CategorySetAssetDescriptionActionQueryBuilderDsl.Of);
        }


    }
}
