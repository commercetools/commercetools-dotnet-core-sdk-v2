using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ShippingQueryBuilderDsl
    {
        public ShippingQueryBuilderDsl()
        {
        }

        public static ShippingQueryBuilderDsl Of()
        {
            return new ShippingQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<ShippingQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<ShippingQueryBuilderDsl>(p, ShippingQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingQueryBuilderDsl> ShippingInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl.Of())),
                ShippingQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingQueryBuilderDsl> ShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                ShippingQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingQueryBuilderDsl> ShippingRateInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRateInput"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl.Of())),
                ShippingQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingQueryBuilderDsl> ShippingCustomFields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingCustomFields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                ShippingQueryBuilderDsl.Of);
        }


    }
}
