using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AttributeGroups
{

    public partial class AttributeGroupAddAttributeActionQueryBuilderDsl
    {
        public AttributeGroupAddAttributeActionQueryBuilderDsl()
        {
        }

        public static AttributeGroupAddAttributeActionQueryBuilderDsl Of()
        {
            return new AttributeGroupAddAttributeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeGroupAddAttributeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<AttributeGroupAddAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<AttributeGroupAddAttributeActionQueryBuilderDsl>(p, AttributeGroupAddAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeGroupAddAttributeActionQueryBuilderDsl> Attribute(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupAddAttributeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attribute"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeReferenceQueryBuilderDsl.Of())),
                AttributeGroupAddAttributeActionQueryBuilderDsl.Of);
        }


    }
}
