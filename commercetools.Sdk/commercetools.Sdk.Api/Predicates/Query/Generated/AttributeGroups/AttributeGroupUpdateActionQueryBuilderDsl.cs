using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AttributeGroups
{

    public partial class AttributeGroupUpdateActionQueryBuilderDsl
    {
        public AttributeGroupUpdateActionQueryBuilderDsl()
        {
        }

        public static AttributeGroupUpdateActionQueryBuilderDsl Of()
        {
            return new AttributeGroupUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeGroupUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<AttributeGroupUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<AttributeGroupUpdateActionQueryBuilderDsl>(p, AttributeGroupUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<AttributeGroupUpdateActionQueryBuilderDsl> AsAddAttribute(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupAddAttributeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupAddAttributeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupAddAttributeActionQueryBuilderDsl.Of()),
                AttributeGroupUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeGroupUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupChangeNameActionQueryBuilderDsl.Of()),
                AttributeGroupUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeGroupUpdateActionQueryBuilderDsl> AsRemoveAttribute(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupRemoveAttributeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupRemoveAttributeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupRemoveAttributeActionQueryBuilderDsl.Of()),
                AttributeGroupUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeGroupUpdateActionQueryBuilderDsl> AsSetAttributes(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupSetAttributesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupSetAttributesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupSetAttributesActionQueryBuilderDsl.Of()),
                AttributeGroupUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeGroupUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupSetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupSetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupSetDescriptionActionQueryBuilderDsl.Of()),
                AttributeGroupUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeGroupUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupSetKeyActionQueryBuilderDsl.Of()),
                AttributeGroupUpdateActionQueryBuilderDsl.Of);
        }
    }
}
