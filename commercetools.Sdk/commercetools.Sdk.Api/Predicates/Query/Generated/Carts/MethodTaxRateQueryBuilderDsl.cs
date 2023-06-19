using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class MethodTaxRateQueryBuilderDsl
    {
        public MethodTaxRateQueryBuilderDsl()
        {
        }

        public static MethodTaxRateQueryBuilderDsl Of()
        {
            return new MethodTaxRateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MethodTaxRateQueryBuilderDsl, string> ShippingMethodKey()
        {
            return new ComparisonPredicateBuilder<MethodTaxRateQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingMethodKey")),
            p => new CombinationQueryPredicate<MethodTaxRateQueryBuilderDsl>(p, MethodTaxRateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MethodTaxRateQueryBuilderDsl> TaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MethodTaxRateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl.Of())),
                MethodTaxRateQueryBuilderDsl.Of);
        }


    }
}
