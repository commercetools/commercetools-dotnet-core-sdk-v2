using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class ProductSelectionSettingQueryBuilderDsl
    {
        public ProductSelectionSettingQueryBuilderDsl()
        {
        }

        public static ProductSelectionSettingQueryBuilderDsl Of()
        {
            return new ProductSelectionSettingQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSelectionSettingQueryBuilderDsl> ProductSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionSettingQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionReferenceQueryBuilderDsl.Of())),
                ProductSelectionSettingQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSelectionSettingQueryBuilderDsl, bool> Active()
        {
            return new ComparisonPredicateBuilder<ProductSelectionSettingQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("active")),
            p => new CombinationQueryPredicate<ProductSelectionSettingQueryBuilderDsl>(p, ProductSelectionSettingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
