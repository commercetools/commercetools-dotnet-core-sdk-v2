using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class AssetSourceQueryBuilderDsl
    {
        public AssetSourceQueryBuilderDsl()
        {
        }

        public static AssetSourceQueryBuilderDsl Of()
        {
            return new AssetSourceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssetSourceQueryBuilderDsl, string> Uri()
        {
            return new ComparisonPredicateBuilder<AssetSourceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("uri")),
            p => new CombinationQueryPredicate<AssetSourceQueryBuilderDsl>(p, AssetSourceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssetSourceQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AssetSourceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AssetSourceQueryBuilderDsl>(p, AssetSourceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssetSourceQueryBuilderDsl> Dimensions(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetDimensionsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetDimensionsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssetSourceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("dimensions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetDimensionsQueryBuilderDsl.Of())),
                AssetSourceQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssetSourceQueryBuilderDsl, string> ContentType()
        {
            return new ComparisonPredicateBuilder<AssetSourceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("contentType")),
            p => new CombinationQueryPredicate<AssetSourceQueryBuilderDsl>(p, AssetSourceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
