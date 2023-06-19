using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ShippingDraftQueryBuilderDsl
    {
        public ShippingDraftQueryBuilderDsl()
        {
        }

        public static ShippingDraftQueryBuilderDsl Of()
        {
            return new ShippingDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ShippingDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ShippingDraftQueryBuilderDsl>(p, ShippingDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingDraftQueryBuilderDsl> ShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingMethod"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodReferenceQueryBuilderDsl.Of())),
                ShippingDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingDraftQueryBuilderDsl> ShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                ShippingDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingDraftQueryBuilderDsl> ShippingRateInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRateInput"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputDraftQueryBuilderDsl.Of())),
                ShippingDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingDraftQueryBuilderDsl> ExternalTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                ShippingDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingDraftQueryBuilderDsl> Deliveries(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("deliveries"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryDraftQueryBuilderDsl.Of())),
                ShippingDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ShippingDraftQueryBuilderDsl> Deliveries()
        {
            return new CollectionPredicateBuilder<ShippingDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveries")),
                    p => new CombinationQueryPredicate<ShippingDraftQueryBuilderDsl>(p, ShippingDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ShippingDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                ShippingDraftQueryBuilderDsl.Of);
        }


    }
}
