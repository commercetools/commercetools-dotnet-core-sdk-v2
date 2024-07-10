using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeNumberTypeQueryBuilderDsl
    {
        public AttributeNumberTypeQueryBuilderDsl()
        {
        }

        public static AttributeNumberTypeQueryBuilderDsl Of()
        {
            return new AttributeNumberTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeNumberTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeNumberTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeNumberTypeQueryBuilderDsl>(p, AttributeNumberTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
