using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl
    {
        public StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl>(p, StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl>(p, StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl, string> DeliveryKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryKey")),
            p => new CombinationQueryPredicate<StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl>(p, StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                StagedOrderSetDeliveryCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
