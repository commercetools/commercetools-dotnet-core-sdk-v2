using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AttributeGroups
{

    public partial class AttributeGroupDraftQueryBuilderDsl
    {
        public AttributeGroupDraftQueryBuilderDsl()
        {
        }

        public static AttributeGroupDraftQueryBuilderDsl Of()
        {
            return new AttributeGroupDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<AttributeGroupDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                AttributeGroupDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AttributeGroupDraftQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                AttributeGroupDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AttributeGroupDraftQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeReferenceQueryBuilderDsl.Of())),
                AttributeGroupDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AttributeGroupDraftQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<AttributeGroupDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<AttributeGroupDraftQueryBuilderDsl>(p, AttributeGroupDraftQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<AttributeGroupDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AttributeGroupDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AttributeGroupDraftQueryBuilderDsl>(p, AttributeGroupDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
