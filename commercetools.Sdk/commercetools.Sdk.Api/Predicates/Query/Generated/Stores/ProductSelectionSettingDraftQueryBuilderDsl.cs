using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class ProductSelectionSettingDraftQueryBuilderDsl
    {
        public ProductSelectionSettingDraftQueryBuilderDsl()
        {
        }

        public static ProductSelectionSettingDraftQueryBuilderDsl Of()
        {
            return new ProductSelectionSettingDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSelectionSettingDraftQueryBuilderDsl> ProductSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionSettingDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionResourceIdentifierQueryBuilderDsl.Of())),
                ProductSelectionSettingDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSelectionSettingDraftQueryBuilderDsl, bool> Active()
        {
            return new ComparisonPredicateBuilder<ProductSelectionSettingDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("active")),
            p => new CombinationQueryPredicate<ProductSelectionSettingDraftQueryBuilderDsl>(p, ProductSelectionSettingDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
