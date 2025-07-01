using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeDefinitionDraftQueryBuilderDsl
    {
        public AttributeDefinitionDraftQueryBuilderDsl()
        {
        }

        public static AttributeDefinitionDraftQueryBuilderDsl Of()
        {
            return new AttributeDefinitionDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<AttributeDefinitionDraftQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeDefinitionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeTypeQueryBuilderDsl.Of())),
                AttributeDefinitionDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AttributeDefinitionDraftQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeDefinitionDraftQueryBuilderDsl>(p, AttributeDefinitionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeDefinitionDraftQueryBuilderDsl> Label(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeDefinitionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("label"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                AttributeDefinitionDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AttributeDefinitionDraftQueryBuilderDsl, bool> IsRequired()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isRequired")),
            p => new CombinationQueryPredicate<AttributeDefinitionDraftQueryBuilderDsl>(p, AttributeDefinitionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeDefinitionDraftQueryBuilderDsl, string> Level()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("level")),
            p => new CombinationQueryPredicate<AttributeDefinitionDraftQueryBuilderDsl>(p, AttributeDefinitionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeDefinitionDraftQueryBuilderDsl, string> AttributeConstraint()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeConstraint")),
            p => new CombinationQueryPredicate<AttributeDefinitionDraftQueryBuilderDsl>(p, AttributeDefinitionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeDefinitionDraftQueryBuilderDsl> InputTip(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeDefinitionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("inputTip"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                AttributeDefinitionDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AttributeDefinitionDraftQueryBuilderDsl, string> InputHint()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inputHint")),
            p => new CombinationQueryPredicate<AttributeDefinitionDraftQueryBuilderDsl>(p, AttributeDefinitionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeDefinitionDraftQueryBuilderDsl, bool> IsSearchable()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isSearchable")),
            p => new CombinationQueryPredicate<AttributeDefinitionDraftQueryBuilderDsl>(p, AttributeDefinitionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
