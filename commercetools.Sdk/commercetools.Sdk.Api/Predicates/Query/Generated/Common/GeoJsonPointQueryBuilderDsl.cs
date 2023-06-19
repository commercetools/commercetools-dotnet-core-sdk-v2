// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class GeoJsonPointQueryBuilderDsl
    {
        public GeoJsonPointQueryBuilderDsl()
        {
        }

        public static GeoJsonPointQueryBuilderDsl Of()
        {
            return new GeoJsonPointQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GeoJsonPointQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<GeoJsonPointQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<GeoJsonPointQueryBuilderDsl>(p, GeoJsonPointQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<GeoJsonPointQueryBuilderDsl, string> Coordinates()
        {
            return new ComparableCollectionPredicateBuilder<GeoJsonPointQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("coordinates")),
            p => new CombinationQueryPredicate<GeoJsonPointQueryBuilderDsl>(p, GeoJsonPointQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
