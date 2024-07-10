using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Zones
{

    public partial class LocationQueryBuilderDsl
    {
        public LocationQueryBuilderDsl()
        {
        }

        public static LocationQueryBuilderDsl Of()
        {
            return new LocationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<LocationQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<LocationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<LocationQueryBuilderDsl>(p, LocationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LocationQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<LocationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<LocationQueryBuilderDsl>(p, LocationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
