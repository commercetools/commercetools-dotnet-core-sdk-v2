using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeDateTypeQueryBuilderDsl
    {
        public AttributeDateTypeQueryBuilderDsl()
        {
        }

        public static AttributeDateTypeQueryBuilderDsl Of()
        {
            return new AttributeDateTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeDateTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeDateTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeDateTypeQueryBuilderDsl>(p, AttributeDateTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
