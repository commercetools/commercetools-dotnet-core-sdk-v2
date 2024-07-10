using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderChangeTaxCalculationModeActionQueryBuilderDsl
    {
        public StagedOrderChangeTaxCalculationModeActionQueryBuilderDsl()
        {
        }

        public static StagedOrderChangeTaxCalculationModeActionQueryBuilderDsl Of()
        {
            return new StagedOrderChangeTaxCalculationModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderChangeTaxCalculationModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeTaxCalculationModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderChangeTaxCalculationModeActionQueryBuilderDsl>(p, StagedOrderChangeTaxCalculationModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderChangeTaxCalculationModeActionQueryBuilderDsl, string> TaxCalculationMode()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeTaxCalculationModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxCalculationMode")),
            p => new CombinationQueryPredicate<StagedOrderChangeTaxCalculationModeActionQueryBuilderDsl>(p, StagedOrderChangeTaxCalculationModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
