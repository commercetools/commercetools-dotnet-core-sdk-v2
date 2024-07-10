using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderChangeTaxModeActionQueryBuilderDsl
    {
        public StagedOrderChangeTaxModeActionQueryBuilderDsl()
        {
        }

        public static StagedOrderChangeTaxModeActionQueryBuilderDsl Of()
        {
            return new StagedOrderChangeTaxModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderChangeTaxModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeTaxModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderChangeTaxModeActionQueryBuilderDsl>(p, StagedOrderChangeTaxModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderChangeTaxModeActionQueryBuilderDsl, string> TaxMode()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeTaxModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxMode")),
            p => new CombinationQueryPredicate<StagedOrderChangeTaxModeActionQueryBuilderDsl>(p, StagedOrderChangeTaxModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
