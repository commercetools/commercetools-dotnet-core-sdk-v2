using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetParcelMeasurementsActionQueryBuilderDsl
    {
        public StagedOrderSetParcelMeasurementsActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetParcelMeasurementsActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetParcelMeasurementsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetParcelMeasurementsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetParcelMeasurementsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetParcelMeasurementsActionQueryBuilderDsl>(p, StagedOrderSetParcelMeasurementsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetParcelMeasurementsActionQueryBuilderDsl, string> ParcelId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetParcelMeasurementsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelId")),
            p => new CombinationQueryPredicate<StagedOrderSetParcelMeasurementsActionQueryBuilderDsl>(p, StagedOrderSetParcelMeasurementsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetParcelMeasurementsActionQueryBuilderDsl, string> ParcelKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetParcelMeasurementsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelKey")),
            p => new CombinationQueryPredicate<StagedOrderSetParcelMeasurementsActionQueryBuilderDsl>(p, StagedOrderSetParcelMeasurementsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetParcelMeasurementsActionQueryBuilderDsl> Measurements(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetParcelMeasurementsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("measurements"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl.Of())),
                StagedOrderSetParcelMeasurementsActionQueryBuilderDsl.Of);
        }


    }
}
