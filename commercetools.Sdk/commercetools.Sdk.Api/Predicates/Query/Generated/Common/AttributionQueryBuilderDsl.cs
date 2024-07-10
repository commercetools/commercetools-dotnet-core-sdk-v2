using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class AttributionQueryBuilderDsl
    {
        public AttributionQueryBuilderDsl()
        {
        }

        public static AttributionQueryBuilderDsl Of()
        {
            return new AttributionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributionQueryBuilderDsl, string> ClientId()
        {
            return new ComparisonPredicateBuilder<AttributionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("clientId")),
            p => new CombinationQueryPredicate<AttributionQueryBuilderDsl>(p, AttributionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributionQueryBuilderDsl, string> Source()
        {
            return new ComparisonPredicateBuilder<AttributionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("source")),
            p => new CombinationQueryPredicate<AttributionQueryBuilderDsl>(p, AttributionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
