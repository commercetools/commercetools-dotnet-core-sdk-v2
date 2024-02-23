using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartAddCustomLineItemActionQueryBuilderDsl
    {
        public CartAddCustomLineItemActionQueryBuilderDsl()
        {
        }

        public static CartAddCustomLineItemActionQueryBuilderDsl Of()
        {
            return new CartAddCustomLineItemActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartAddCustomLineItemActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartAddCustomLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl>(p, CartAddCustomLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl> Money(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("money"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                CartAddCustomLineItemActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CartAddCustomLineItemActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartAddCustomLineItemActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CartAddCustomLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl>(p, CartAddCustomLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartAddCustomLineItemActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<CartAddCustomLineItemActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl>(p, CartAddCustomLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartAddCustomLineItemActionQueryBuilderDsl, string> Slug()
        {
            return new ComparisonPredicateBuilder<CartAddCustomLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("slug")),
            p => new CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl>(p, CartAddCustomLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl> TaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxCategory"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl.Of())),
                CartAddCustomLineItemActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl> ExternalTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                CartAddCustomLineItemActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl> ShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingDetails"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl.Of())),
                CartAddCustomLineItemActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                CartAddCustomLineItemActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartAddCustomLineItemActionQueryBuilderDsl, string> PriceMode()
        {
            return new ComparisonPredicateBuilder<CartAddCustomLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceMode")),
            p => new CombinationQueryPredicate<CartAddCustomLineItemActionQueryBuilderDsl>(p, CartAddCustomLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
