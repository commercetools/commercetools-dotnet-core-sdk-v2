using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderChangeTaxRoundingModeActionQueryBuilderDsl
    {
        public StagedOrderChangeTaxRoundingModeActionQueryBuilderDsl()
        {
        }

        public static StagedOrderChangeTaxRoundingModeActionQueryBuilderDsl Of()
        {
            return new StagedOrderChangeTaxRoundingModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderChangeTaxRoundingModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeTaxRoundingModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderChangeTaxRoundingModeActionQueryBuilderDsl>(p, StagedOrderChangeTaxRoundingModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderChangeTaxRoundingModeActionQueryBuilderDsl, string> TaxRoundingMode()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeTaxRoundingModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxRoundingMode")),
            p => new CombinationQueryPredicate<StagedOrderChangeTaxRoundingModeActionQueryBuilderDsl>(p, StagedOrderChangeTaxRoundingModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
