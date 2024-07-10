using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingRateDraftQueryBuilderDsl
    {
        public ShippingRateDraftQueryBuilderDsl()
        {
        }

        public static ShippingRateDraftQueryBuilderDsl Of()
        {
            return new ShippingRateDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ShippingRateDraftQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingRateDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                ShippingRateDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingRateDraftQueryBuilderDsl> FreeAbove(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingRateDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("freeAbove"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                ShippingRateDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingRateDraftQueryBuilderDsl> Tiers(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRatePriceTierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRatePriceTierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingRateDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("tiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRatePriceTierQueryBuilderDsl.Of())),
                ShippingRateDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ShippingRateDraftQueryBuilderDsl> Tiers()
        {
            return new CollectionPredicateBuilder<ShippingRateDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tiers")),
                    p => new CombinationQueryPredicate<ShippingRateDraftQueryBuilderDsl>(p, ShippingRateDraftQueryBuilderDsl.Of));
        }

    }
}
