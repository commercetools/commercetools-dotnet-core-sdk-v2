using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class AssignedProductSelectionQueryBuilderDsl
    {
        public AssignedProductSelectionQueryBuilderDsl()
        {
        }

        public static AssignedProductSelectionQueryBuilderDsl Of()
        {
            return new AssignedProductSelectionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<AssignedProductSelectionQueryBuilderDsl> ProductSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssignedProductSelectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionReferenceQueryBuilderDsl.Of())),
                AssignedProductSelectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AssignedProductSelectionQueryBuilderDsl> VariantSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssignedProductSelectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variantSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl.Of())),
                AssignedProductSelectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AssignedProductSelectionQueryBuilderDsl> VariantExclusion(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssignedProductSelectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variantExclusion"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl.Of())),
                AssignedProductSelectionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssignedProductSelectionQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<AssignedProductSelectionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<AssignedProductSelectionQueryBuilderDsl>(p, AssignedProductSelectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
