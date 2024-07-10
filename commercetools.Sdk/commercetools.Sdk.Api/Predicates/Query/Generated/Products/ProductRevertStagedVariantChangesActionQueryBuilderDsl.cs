using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductRevertStagedVariantChangesActionQueryBuilderDsl
    {
        public ProductRevertStagedVariantChangesActionQueryBuilderDsl()
        {
        }

        public static ProductRevertStagedVariantChangesActionQueryBuilderDsl Of()
        {
            return new ProductRevertStagedVariantChangesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductRevertStagedVariantChangesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductRevertStagedVariantChangesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductRevertStagedVariantChangesActionQueryBuilderDsl>(p, ProductRevertStagedVariantChangesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRevertStagedVariantChangesActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductRevertStagedVariantChangesActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductRevertStagedVariantChangesActionQueryBuilderDsl>(p, ProductRevertStagedVariantChangesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
