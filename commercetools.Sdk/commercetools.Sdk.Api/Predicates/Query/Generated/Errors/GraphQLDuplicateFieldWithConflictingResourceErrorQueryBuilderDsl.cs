using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl
    {
        public GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl()
        {
        }

        public static GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl Of()
        {
            return new GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl>(p, GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl>(p, GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl, string> DuplicateValue()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("duplicateValue")),
            p => new CombinationQueryPredicate<GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl>(p, GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl> ConflictingResource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("conflictingResource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl.Of);
        }


    }
}
