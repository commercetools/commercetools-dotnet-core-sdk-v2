using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreDeletedMessagePayloadQueryBuilderDsl
    {
        public StoreDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreDeletedMessagePayloadQueryBuilderDsl>(p, StoreDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
