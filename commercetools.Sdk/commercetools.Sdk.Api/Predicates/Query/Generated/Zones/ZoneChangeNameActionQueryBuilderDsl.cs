using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Zones
{

    public partial class ZoneChangeNameActionQueryBuilderDsl
    {
        public ZoneChangeNameActionQueryBuilderDsl()
        {
        }

        public static ZoneChangeNameActionQueryBuilderDsl Of()
        {
            return new ZoneChangeNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ZoneChangeNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ZoneChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ZoneChangeNameActionQueryBuilderDsl>(p, ZoneChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ZoneChangeNameActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ZoneChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ZoneChangeNameActionQueryBuilderDsl>(p, ZoneChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
