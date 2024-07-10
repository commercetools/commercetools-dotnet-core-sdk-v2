using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeReferenceTypeQueryBuilderDsl
    {
        public AttributeReferenceTypeQueryBuilderDsl()
        {
        }

        public static AttributeReferenceTypeQueryBuilderDsl Of()
        {
            return new AttributeReferenceTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeReferenceTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeReferenceTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeReferenceTypeQueryBuilderDsl>(p, AttributeReferenceTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeReferenceTypeQueryBuilderDsl, string> ReferenceTypeId()
        {
            return new ComparisonPredicateBuilder<AttributeReferenceTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("referenceTypeId")),
            p => new CombinationQueryPredicate<AttributeReferenceTypeQueryBuilderDsl>(p, AttributeReferenceTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
