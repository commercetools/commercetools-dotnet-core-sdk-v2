using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartAddShippingMethodActionQueryBuilderDsl
    {
        public CartAddShippingMethodActionQueryBuilderDsl()
        {
        }

        public static CartAddShippingMethodActionQueryBuilderDsl Of()
        {
            return new CartAddShippingMethodActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartAddShippingMethodActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartAddShippingMethodActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartAddShippingMethodActionQueryBuilderDsl>(p, CartAddShippingMethodActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartAddShippingMethodActionQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<CartAddShippingMethodActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<CartAddShippingMethodActionQueryBuilderDsl>(p, CartAddShippingMethodActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartAddShippingMethodActionQueryBuilderDsl> ShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingMethod"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl.Of())),
                CartAddShippingMethodActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartAddShippingMethodActionQueryBuilderDsl> ShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                CartAddShippingMethodActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartAddShippingMethodActionQueryBuilderDsl> ShippingRateInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRateInput"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputDraftQueryBuilderDsl.Of())),
                CartAddShippingMethodActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartAddShippingMethodActionQueryBuilderDsl> ExternalTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                CartAddShippingMethodActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartAddShippingMethodActionQueryBuilderDsl> Deliveries(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("deliveries"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryDraftQueryBuilderDsl.Of())),
                CartAddShippingMethodActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartAddShippingMethodActionQueryBuilderDsl> Deliveries()
        {
            return new CollectionPredicateBuilder<CartAddShippingMethodActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveries")),
                    p => new CombinationQueryPredicate<CartAddShippingMethodActionQueryBuilderDsl>(p, CartAddShippingMethodActionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CartAddShippingMethodActionQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartAddShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                CartAddShippingMethodActionQueryBuilderDsl.Of);
        }


    }
}
