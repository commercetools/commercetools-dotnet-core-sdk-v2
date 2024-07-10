using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl
    {
        public StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl>(p, StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl>(p, StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                StagedOrderSetItemShippingAddressCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
