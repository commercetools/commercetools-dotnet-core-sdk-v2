using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodChangeTaxCategoryActionQueryBuilderDsl
    {
        public ShippingMethodChangeTaxCategoryActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodChangeTaxCategoryActionQueryBuilderDsl Of()
        {
            return new ShippingMethodChangeTaxCategoryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodChangeTaxCategoryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodChangeTaxCategoryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodChangeTaxCategoryActionQueryBuilderDsl>(p, ShippingMethodChangeTaxCategoryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodChangeTaxCategoryActionQueryBuilderDsl> TaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodChangeTaxCategoryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxCategory"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl.Of())),
                ShippingMethodChangeTaxCategoryActionQueryBuilderDsl.Of);
        }


    }
}
