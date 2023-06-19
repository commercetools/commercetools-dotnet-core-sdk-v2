using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AttributeGroups
{

    public partial class AttributeGroupSetAttributesActionQueryBuilderDsl
    {
        public AttributeGroupSetAttributesActionQueryBuilderDsl()
        {
        }

        public static AttributeGroupSetAttributesActionQueryBuilderDsl Of()
        {
            return new AttributeGroupSetAttributesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeGroupSetAttributesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<AttributeGroupSetAttributesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<AttributeGroupSetAttributesActionQueryBuilderDsl>(p, AttributeGroupSetAttributesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeGroupSetAttributesActionQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupSetAttributesActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeReferenceQueryBuilderDsl.Of())),
                AttributeGroupSetAttributesActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AttributeGroupSetAttributesActionQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<AttributeGroupSetAttributesActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<AttributeGroupSetAttributesActionQueryBuilderDsl>(p, AttributeGroupSetAttributesActionQueryBuilderDsl.Of));
        }

    }
}
