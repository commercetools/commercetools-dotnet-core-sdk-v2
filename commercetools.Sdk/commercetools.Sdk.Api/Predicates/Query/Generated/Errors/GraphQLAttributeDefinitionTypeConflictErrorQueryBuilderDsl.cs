using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl
    {
        public GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl Of()
        {
            return new GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl>(p, GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl, string> ConflictingProductTypeId()
        {
            return new ComparisonPredicateBuilder<GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingProductTypeId")),
            p => new CombinationQueryPredicate<GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl>(p, GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl, string> ConflictingProductTypeName()
        {
            return new ComparisonPredicateBuilder<GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingProductTypeName")),
            p => new CombinationQueryPredicate<GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl>(p, GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl, string> ConflictingAttributeName()
        {
            return new ComparisonPredicateBuilder<GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingAttributeName")),
            p => new CombinationQueryPredicate<GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl>(p, GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
