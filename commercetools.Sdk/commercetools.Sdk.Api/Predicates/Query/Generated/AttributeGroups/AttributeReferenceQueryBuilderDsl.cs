using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AttributeGroups
{

    public partial class AttributeReferenceQueryBuilderDsl
    {
        public AttributeReferenceQueryBuilderDsl()
        {
        }

        public static AttributeReferenceQueryBuilderDsl Of()
        {
            return new AttributeReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeReferenceQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AttributeReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AttributeReferenceQueryBuilderDsl>(p, AttributeReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
