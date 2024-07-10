using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeTimeTypeQueryBuilderDsl
    {
        public AttributeTimeTypeQueryBuilderDsl()
        {
        }

        public static AttributeTimeTypeQueryBuilderDsl Of()
        {
            return new AttributeTimeTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeTimeTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeTimeTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeTimeTypeQueryBuilderDsl>(p, AttributeTimeTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
