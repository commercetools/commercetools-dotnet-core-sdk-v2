// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class AssetDimensionsQueryBuilderDsl
    {
        public AssetDimensionsQueryBuilderDsl()
        {
        }

        public static AssetDimensionsQueryBuilderDsl Of()
        {
            return new AssetDimensionsQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssetDimensionsQueryBuilderDsl, long> W()
        {
            return new ComparisonPredicateBuilder<AssetDimensionsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("w")),
            p => new CombinationQueryPredicate<AssetDimensionsQueryBuilderDsl>(p, AssetDimensionsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssetDimensionsQueryBuilderDsl, long> H()
        {
            return new ComparisonPredicateBuilder<AssetDimensionsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("h")),
            p => new CombinationQueryPredicate<AssetDimensionsQueryBuilderDsl>(p, AssetDimensionsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
