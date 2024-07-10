using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl
    {
        public AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl()
        {
        }

        public static AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl Of()
        {
            return new AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl>(p, AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl>(p, AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string> ConflictingProductTypeId()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingProductTypeId")),
            p => new CombinationQueryPredicate<AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl>(p, AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string> ConflictingProductTypeName()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingProductTypeName")),
            p => new CombinationQueryPredicate<AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl>(p, AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string> ConflictingAttributeName()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingAttributeName")),
            p => new CombinationQueryPredicate<AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl>(p, AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
