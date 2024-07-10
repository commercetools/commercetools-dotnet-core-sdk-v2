using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AttributeGroups
{

    public partial class AttributeGroupRemoveAttributeActionQueryBuilderDsl
    {
        public AttributeGroupRemoveAttributeActionQueryBuilderDsl()
        {
        }

        public static AttributeGroupRemoveAttributeActionQueryBuilderDsl Of()
        {
            return new AttributeGroupRemoveAttributeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeGroupRemoveAttributeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<AttributeGroupRemoveAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<AttributeGroupRemoveAttributeActionQueryBuilderDsl>(p, AttributeGroupRemoveAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeGroupRemoveAttributeActionQueryBuilderDsl> Attribute(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupRemoveAttributeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attribute"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeReferenceQueryBuilderDsl.Of())),
                AttributeGroupRemoveAttributeActionQueryBuilderDsl.Of);
        }


    }
}
