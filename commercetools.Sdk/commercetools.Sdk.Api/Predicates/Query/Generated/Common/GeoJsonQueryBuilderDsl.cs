using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class GeoJsonQueryBuilderDsl
    {
        public GeoJsonQueryBuilderDsl()
        {
        }

        public static GeoJsonQueryBuilderDsl Of()
        {
            return new GeoJsonQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GeoJsonQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<GeoJsonQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<GeoJsonQueryBuilderDsl>(p, GeoJsonQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<GeoJsonQueryBuilderDsl> AsPoint(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.GeoJsonPointQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.GeoJsonPointQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GeoJsonQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.GeoJsonPointQueryBuilderDsl.Of()),
                GeoJsonQueryBuilderDsl.Of);
        }
    }
}
