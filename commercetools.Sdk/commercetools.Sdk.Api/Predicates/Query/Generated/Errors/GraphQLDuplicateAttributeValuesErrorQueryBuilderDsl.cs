using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl
    {
        public GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl()
        {
        }

        public static GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl Of()
        {
            return new GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl>(p, GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl>(p, GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl.Of));
        }

    }
}
