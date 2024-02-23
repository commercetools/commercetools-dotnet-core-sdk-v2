using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class AssetQueryBuilderDsl
    {
        public AssetQueryBuilderDsl()
        {
        }

        public static AssetQueryBuilderDsl Of()
        {
            return new AssetQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssetQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<AssetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<AssetQueryBuilderDsl>(p, AssetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssetQueryBuilderDsl> Sources(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetSourceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetSourceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssetQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("sources"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetSourceQueryBuilderDsl.Of())),
                AssetQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AssetQueryBuilderDsl> Sources()
        {
            return new CollectionPredicateBuilder<AssetQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sources")),
                    p => new CombinationQueryPredicate<AssetQueryBuilderDsl>(p, AssetQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<AssetQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssetQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                AssetQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AssetQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssetQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                AssetQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<AssetQueryBuilderDsl, string> Tags()
        {
            return new ComparableCollectionPredicateBuilder<AssetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tags")),
            p => new CombinationQueryPredicate<AssetQueryBuilderDsl>(p, AssetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssetQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssetQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                AssetQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssetQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AssetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AssetQueryBuilderDsl>(p, AssetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
