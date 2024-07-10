using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl
    {
        public GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl()
        {
        }

        public static GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl Of()
        {
            return new GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl>(p, GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl>(p, GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl>(p, GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl>(p, GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
