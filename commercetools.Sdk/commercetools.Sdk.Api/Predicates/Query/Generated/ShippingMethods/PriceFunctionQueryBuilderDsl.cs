using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class PriceFunctionQueryBuilderDsl
    {
        public PriceFunctionQueryBuilderDsl()
        {
        }

        public static PriceFunctionQueryBuilderDsl Of()
        {
            return new PriceFunctionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PriceFunctionQueryBuilderDsl, string> CurrencyCode()
        {
            return new ComparisonPredicateBuilder<PriceFunctionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currencyCode")),
            p => new CombinationQueryPredicate<PriceFunctionQueryBuilderDsl>(p, PriceFunctionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PriceFunctionQueryBuilderDsl, string> Function()
        {
            return new ComparisonPredicateBuilder<PriceFunctionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("function")),
            p => new CombinationQueryPredicate<PriceFunctionQueryBuilderDsl>(p, PriceFunctionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
