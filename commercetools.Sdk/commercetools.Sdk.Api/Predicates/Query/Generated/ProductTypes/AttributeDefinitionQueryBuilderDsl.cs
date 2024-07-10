using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeDefinitionQueryBuilderDsl
    {
        public AttributeDefinitionQueryBuilderDsl()
        {
        }

        public static AttributeDefinitionQueryBuilderDsl Of()
        {
            return new AttributeDefinitionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<AttributeDefinitionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeDefinitionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeTypeQueryBuilderDsl.Of())),
                AttributeDefinitionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AttributeDefinitionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeDefinitionQueryBuilderDsl>(p, AttributeDefinitionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeDefinitionQueryBuilderDsl> Label(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeDefinitionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("label"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                AttributeDefinitionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AttributeDefinitionQueryBuilderDsl, bool> IsRequired()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isRequired")),
            p => new CombinationQueryPredicate<AttributeDefinitionQueryBuilderDsl>(p, AttributeDefinitionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeDefinitionQueryBuilderDsl, string> AttributeConstraint()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeConstraint")),
            p => new CombinationQueryPredicate<AttributeDefinitionQueryBuilderDsl>(p, AttributeDefinitionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeDefinitionQueryBuilderDsl> InputTip(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeDefinitionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("inputTip"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                AttributeDefinitionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AttributeDefinitionQueryBuilderDsl, string> InputHint()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inputHint")),
            p => new CombinationQueryPredicate<AttributeDefinitionQueryBuilderDsl>(p, AttributeDefinitionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeDefinitionQueryBuilderDsl, bool> IsSearchable()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isSearchable")),
            p => new CombinationQueryPredicate<AttributeDefinitionQueryBuilderDsl>(p, AttributeDefinitionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
