using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl
    {
        public GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl()
        {
        }

        public static GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl Of()
        {
            return new GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl>(p, GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl> ExistingVariantSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("existingVariantSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl.Of())),
                GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl.Of);
        }


    }
}
