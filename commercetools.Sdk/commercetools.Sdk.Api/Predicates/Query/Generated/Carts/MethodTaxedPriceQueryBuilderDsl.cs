using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class MethodTaxedPriceQueryBuilderDsl
    {
        public MethodTaxedPriceQueryBuilderDsl()
        {
        }

        public static MethodTaxedPriceQueryBuilderDsl Of()
        {
            return new MethodTaxedPriceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MethodTaxedPriceQueryBuilderDsl, string> ShippingMethodKey()
        {
            return new ComparisonPredicateBuilder<MethodTaxedPriceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingMethodKey")),
            p => new CombinationQueryPredicate<MethodTaxedPriceQueryBuilderDsl>(p, MethodTaxedPriceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MethodTaxedPriceQueryBuilderDsl> TaxedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MethodTaxedPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl.Of())),
                MethodTaxedPriceQueryBuilderDsl.Of);
        }


    }
}
