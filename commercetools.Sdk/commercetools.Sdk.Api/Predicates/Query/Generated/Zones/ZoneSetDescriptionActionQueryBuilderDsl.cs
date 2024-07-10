using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Zones
{

    public partial class ZoneSetDescriptionActionQueryBuilderDsl
    {
        public ZoneSetDescriptionActionQueryBuilderDsl()
        {
        }

        public static ZoneSetDescriptionActionQueryBuilderDsl Of()
        {
            return new ZoneSetDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ZoneSetDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ZoneSetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ZoneSetDescriptionActionQueryBuilderDsl>(p, ZoneSetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ZoneSetDescriptionActionQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<ZoneSetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<ZoneSetDescriptionActionQueryBuilderDsl>(p, ZoneSetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
