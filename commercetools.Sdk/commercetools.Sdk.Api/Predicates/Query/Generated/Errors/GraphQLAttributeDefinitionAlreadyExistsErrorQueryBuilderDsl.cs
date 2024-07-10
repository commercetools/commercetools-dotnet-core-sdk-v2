using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl
    {
        public GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl Of()
        {
            return new GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl>(p, GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string> ConflictingProductTypeId()
        {
            return new ComparisonPredicateBuilder<GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingProductTypeId")),
            p => new CombinationQueryPredicate<GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl>(p, GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string> ConflictingProductTypeName()
        {
            return new ComparisonPredicateBuilder<GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingProductTypeName")),
            p => new CombinationQueryPredicate<GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl>(p, GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string> ConflictingAttributeName()
        {
            return new ComparisonPredicateBuilder<GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("conflictingAttributeName")),
            p => new CombinationQueryPredicate<GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl>(p, GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
