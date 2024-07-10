using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLDuplicateAttributeValueErrorQueryBuilderDsl
    {
        public GraphQLDuplicateAttributeValueErrorQueryBuilderDsl()
        {
        }

        public static GraphQLDuplicateAttributeValueErrorQueryBuilderDsl Of()
        {
            return new GraphQLDuplicateAttributeValueErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLDuplicateAttributeValueErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicateAttributeValueErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLDuplicateAttributeValueErrorQueryBuilderDsl>(p, GraphQLDuplicateAttributeValueErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLDuplicateAttributeValueErrorQueryBuilderDsl> Attribute(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLDuplicateAttributeValueErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attribute"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                GraphQLDuplicateAttributeValueErrorQueryBuilderDsl.Of);
        }


    }
}
