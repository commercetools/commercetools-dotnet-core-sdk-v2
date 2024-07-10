using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl
    {
        public StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl()
        {
        }

        public static StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl Of()
        {
            return new StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl>(p, StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl, string> ParcelId()
        {
            return new ComparisonPredicateBuilder<StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelId")),
            p => new CombinationQueryPredicate<StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl>(p, StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl, string> ParcelKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelKey")),
            p => new CombinationQueryPredicate<StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl>(p, StagedOrderRemoveParcelFromDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
