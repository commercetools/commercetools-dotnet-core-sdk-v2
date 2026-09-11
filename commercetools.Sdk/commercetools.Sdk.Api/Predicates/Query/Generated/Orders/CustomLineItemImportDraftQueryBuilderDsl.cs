using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class CustomLineItemImportDraftQueryBuilderDsl
    {
        public CustomLineItemImportDraftQueryBuilderDsl()
        {
        }

        public static CustomLineItemImportDraftQueryBuilderDsl Of()
        {
            return new CustomLineItemImportDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CustomLineItemImportDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomLineItemImportDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CustomLineItemImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl>(p, CustomLineItemImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemImportDraftQueryBuilderDsl, string> Slug()
        {
            return new ComparisonPredicateBuilder<CustomLineItemImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("slug")),
            p => new CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl>(p, CustomLineItemImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemImportDraftQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<CustomLineItemImportDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl>(p, CustomLineItemImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl> Money(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("money"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                CustomLineItemImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl> TaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl.Of())),
                CustomLineItemImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl> TaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxCategory"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl.Of())),
                CustomLineItemImportDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomLineItemImportDraftQueryBuilderDsl, string> PriceMode()
        {
            return new ComparisonPredicateBuilder<CustomLineItemImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceMode")),
            p => new CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl>(p, CustomLineItemImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl> ShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingDetails"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl.Of())),
                CustomLineItemImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl.Of())),
                CustomLineItemImportDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomLineItemImportDraftQueryBuilderDsl> State()
        {
            return new CollectionPredicateBuilder<CustomLineItemImportDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
                    p => new CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl>(p, CustomLineItemImportDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                CustomLineItemImportDraftQueryBuilderDsl.Of);
        }


    }
}
