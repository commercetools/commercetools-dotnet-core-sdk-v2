using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Zones
{

    public partial class ZonePagedQueryResponseQueryBuilderDsl
    {
        public ZonePagedQueryResponseQueryBuilderDsl()
        {
        }

        public static ZonePagedQueryResponseQueryBuilderDsl Of()
        {
            return new ZonePagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ZonePagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ZonePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ZonePagedQueryResponseQueryBuilderDsl>(p, ZonePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ZonePagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ZonePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ZonePagedQueryResponseQueryBuilderDsl>(p, ZonePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ZonePagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ZonePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ZonePagedQueryResponseQueryBuilderDsl>(p, ZonePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ZonePagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<ZonePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<ZonePagedQueryResponseQueryBuilderDsl>(p, ZonePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ZonePagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZonePagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneQueryBuilderDsl.Of())),
                ZonePagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ZonePagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ZonePagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ZonePagedQueryResponseQueryBuilderDsl>(p, ZonePagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
