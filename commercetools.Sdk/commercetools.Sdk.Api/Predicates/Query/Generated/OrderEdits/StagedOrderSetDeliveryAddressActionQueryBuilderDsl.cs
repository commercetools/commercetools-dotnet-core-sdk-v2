using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetDeliveryAddressActionQueryBuilderDsl
    {
        public StagedOrderSetDeliveryAddressActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetDeliveryAddressActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetDeliveryAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetDeliveryAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryAddressActionQueryBuilderDsl>(p, StagedOrderSetDeliveryAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetDeliveryAddressActionQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryAddressActionQueryBuilderDsl>(p, StagedOrderSetDeliveryAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetDeliveryAddressActionQueryBuilderDsl, string> DeliveryKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryKey")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryAddressActionQueryBuilderDsl>(p, StagedOrderSetDeliveryAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetDeliveryAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetDeliveryAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                StagedOrderSetDeliveryAddressActionQueryBuilderDsl.Of);
        }


    }
}
