using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ExternalLineItemTotalPriceQueryBuilderDsl
    {
        public ExternalLineItemTotalPriceQueryBuilderDsl()
        {
        }

        public static ExternalLineItemTotalPriceQueryBuilderDsl Of()
        {
            return new ExternalLineItemTotalPriceQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ExternalLineItemTotalPriceQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExternalLineItemTotalPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                ExternalLineItemTotalPriceQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ExternalLineItemTotalPriceQueryBuilderDsl> TotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExternalLineItemTotalPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                ExternalLineItemTotalPriceQueryBuilderDsl.Of);
        }


    }
}
