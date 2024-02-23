using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductSelectionDraftQueryBuilderDsl
    {
        public ProductSelectionDraftQueryBuilderDsl()
        {
        }

        public static ProductSelectionDraftQueryBuilderDsl Of()
        {
            return new ProductSelectionDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSelectionDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductSelectionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductSelectionDraftQueryBuilderDsl>(p, ProductSelectionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSelectionDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductSelectionDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSelectionDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                ProductSelectionDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSelectionDraftQueryBuilderDsl, string> Mode()
        {
            return new ComparisonPredicateBuilder<ProductSelectionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mode")),
            p => new CombinationQueryPredicate<ProductSelectionDraftQueryBuilderDsl>(p, ProductSelectionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
