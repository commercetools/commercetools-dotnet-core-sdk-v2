using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class AttributeDefinitionTypeConflictErrorQueryBuilderDsl
    {
        public AttributeDefinitionTypeConflictErrorQueryBuilderDsl()
        {
        }

        public static AttributeDefinitionTypeConflictErrorQueryBuilderDsl Of()
        {
            return new AttributeDefinitionTypeConflictErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeDefinitionTypeConflictErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionTypeConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AttributeDefinitionTypeConflictErrorQueryBuilderDsl>(p, AttributeDefinitionTypeConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeDefinitionTypeConflictErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionTypeConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AttributeDefinitionTypeConflictErrorQueryBuilderDsl>(p, AttributeDefinitionTypeConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeDefinitionTypeConflictErrorQueryBuilderDsl, string> ConflictingProductTypeId()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionTypeConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingProductTypeId")),
            p => new CombinationQueryPredicate<AttributeDefinitionTypeConflictErrorQueryBuilderDsl>(p, AttributeDefinitionTypeConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeDefinitionTypeConflictErrorQueryBuilderDsl, string> ConflictingProductTypeName()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionTypeConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingProductTypeName")),
            p => new CombinationQueryPredicate<AttributeDefinitionTypeConflictErrorQueryBuilderDsl>(p, AttributeDefinitionTypeConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeDefinitionTypeConflictErrorQueryBuilderDsl, string> ConflictingAttributeName()
        {
            return new ComparisonPredicateBuilder<AttributeDefinitionTypeConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingAttributeName")),
            p => new CombinationQueryPredicate<AttributeDefinitionTypeConflictErrorQueryBuilderDsl>(p, AttributeDefinitionTypeConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
