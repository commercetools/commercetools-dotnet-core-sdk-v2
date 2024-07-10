using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CustomLineItemDraftQueryBuilderDsl
    {
        public CustomLineItemDraftQueryBuilderDsl()
        {
        }

        public static CustomLineItemDraftQueryBuilderDsl Of()
        {
            return new CustomLineItemDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<CustomLineItemDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CustomLineItemDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomLineItemDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CustomLineItemDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CustomLineItemDraftQueryBuilderDsl>(p, CustomLineItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemDraftQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<CustomLineItemDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<CustomLineItemDraftQueryBuilderDsl>(p, CustomLineItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomLineItemDraftQueryBuilderDsl> Money(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("money"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                CustomLineItemDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomLineItemDraftQueryBuilderDsl, string> Slug()
        {
            return new ComparisonPredicateBuilder<CustomLineItemDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("slug")),
            p => new CombinationQueryPredicate<CustomLineItemDraftQueryBuilderDsl>(p, CustomLineItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomLineItemDraftQueryBuilderDsl> TaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxCategory"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl.Of())),
                CustomLineItemDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomLineItemDraftQueryBuilderDsl> ExternalTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                CustomLineItemDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomLineItemDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                CustomLineItemDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomLineItemDraftQueryBuilderDsl> ShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingDetails"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl.Of())),
                CustomLineItemDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomLineItemDraftQueryBuilderDsl, string> PriceMode()
        {
            return new ComparisonPredicateBuilder<CustomLineItemDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceMode")),
            p => new CombinationQueryPredicate<CustomLineItemDraftQueryBuilderDsl>(p, CustomLineItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
