using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderBusinessUnitSetMessagePayloadQueryBuilderDsl
    {
        public OrderBusinessUnitSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderBusinessUnitSetMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderBusinessUnitSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderBusinessUnitSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderBusinessUnitSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderBusinessUnitSetMessagePayloadQueryBuilderDsl>(p, OrderBusinessUnitSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderBusinessUnitSetMessagePayloadQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderBusinessUnitSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                OrderBusinessUnitSetMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderBusinessUnitSetMessagePayloadQueryBuilderDsl> OldbusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderBusinessUnitSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldbusinessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                OrderBusinessUnitSetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
