using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Zones
{

    public partial class ZoneReferenceQueryBuilderDsl
    {
        public ZoneReferenceQueryBuilderDsl()
        {
        }

        public static ZoneReferenceQueryBuilderDsl Of()
        {
            return new ZoneReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ZoneReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ZoneReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ZoneReferenceQueryBuilderDsl>(p, ZoneReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ZoneReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ZoneReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ZoneReferenceQueryBuilderDsl>(p, ZoneReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ZoneReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneQueryBuilderDsl.Of())),
                ZoneReferenceQueryBuilderDsl.Of);
        }


    }
}
