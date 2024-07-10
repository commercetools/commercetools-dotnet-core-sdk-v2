using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetParcelMeasurementsActionQueryBuilderDsl
    {
        public OrderSetParcelMeasurementsActionQueryBuilderDsl()
        {
        }

        public static OrderSetParcelMeasurementsActionQueryBuilderDsl Of()
        {
            return new OrderSetParcelMeasurementsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetParcelMeasurementsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetParcelMeasurementsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetParcelMeasurementsActionQueryBuilderDsl>(p, OrderSetParcelMeasurementsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetParcelMeasurementsActionQueryBuilderDsl, string> ParcelId()
        {
            return new ComparisonPredicateBuilder<OrderSetParcelMeasurementsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelId")),
            p => new CombinationQueryPredicate<OrderSetParcelMeasurementsActionQueryBuilderDsl>(p, OrderSetParcelMeasurementsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetParcelMeasurementsActionQueryBuilderDsl, string> ParcelKey()
        {
            return new ComparisonPredicateBuilder<OrderSetParcelMeasurementsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelKey")),
            p => new CombinationQueryPredicate<OrderSetParcelMeasurementsActionQueryBuilderDsl>(p, OrderSetParcelMeasurementsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetParcelMeasurementsActionQueryBuilderDsl> Measurements(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetParcelMeasurementsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("measurements"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl.Of())),
                OrderSetParcelMeasurementsActionQueryBuilderDsl.Of);
        }


    }
}
