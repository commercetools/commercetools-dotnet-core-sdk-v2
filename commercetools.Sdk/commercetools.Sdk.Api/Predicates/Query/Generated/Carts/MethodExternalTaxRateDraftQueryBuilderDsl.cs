using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class MethodExternalTaxRateDraftQueryBuilderDsl
    {
        public MethodExternalTaxRateDraftQueryBuilderDsl()
        {
        }

        public static MethodExternalTaxRateDraftQueryBuilderDsl Of()
        {
            return new MethodExternalTaxRateDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MethodExternalTaxRateDraftQueryBuilderDsl, string> ShippingMethodKey()
        {
            return new ComparisonPredicateBuilder<MethodExternalTaxRateDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingMethodKey")),
            p => new CombinationQueryPredicate<MethodExternalTaxRateDraftQueryBuilderDsl>(p, MethodExternalTaxRateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MethodExternalTaxRateDraftQueryBuilderDsl> TaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MethodExternalTaxRateDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                MethodExternalTaxRateDraftQueryBuilderDsl.Of);
        }


    }
}
