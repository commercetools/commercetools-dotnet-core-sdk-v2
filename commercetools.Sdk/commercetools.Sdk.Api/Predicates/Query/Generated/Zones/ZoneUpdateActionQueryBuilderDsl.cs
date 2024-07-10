using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Zones
{

    public partial class ZoneUpdateActionQueryBuilderDsl
    {
        public ZoneUpdateActionQueryBuilderDsl()
        {
        }

        public static ZoneUpdateActionQueryBuilderDsl Of()
        {
            return new ZoneUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ZoneUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ZoneUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ZoneUpdateActionQueryBuilderDsl>(p, ZoneUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ZoneUpdateActionQueryBuilderDsl> AsAddLocation(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneAddLocationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneAddLocationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneAddLocationActionQueryBuilderDsl.Of()),
                ZoneUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ZoneUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneChangeNameActionQueryBuilderDsl.Of()),
                ZoneUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ZoneUpdateActionQueryBuilderDsl> AsRemoveLocation(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneRemoveLocationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneRemoveLocationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneRemoveLocationActionQueryBuilderDsl.Of()),
                ZoneUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ZoneUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneSetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneSetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneSetDescriptionActionQueryBuilderDsl.Of()),
                ZoneUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ZoneUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneSetKeyActionQueryBuilderDsl.Of()),
                ZoneUpdateActionQueryBuilderDsl.Of);
        }
    }
}
