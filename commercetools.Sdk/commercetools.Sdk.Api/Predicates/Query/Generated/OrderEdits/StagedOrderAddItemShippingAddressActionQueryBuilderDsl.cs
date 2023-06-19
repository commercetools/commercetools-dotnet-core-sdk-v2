using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderAddItemShippingAddressActionQueryBuilderDsl
    {
        public StagedOrderAddItemShippingAddressActionQueryBuilderDsl()
        {
        }

        public static StagedOrderAddItemShippingAddressActionQueryBuilderDsl Of()
        {
            return new StagedOrderAddItemShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderAddItemShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddItemShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderAddItemShippingAddressActionQueryBuilderDsl>(p, StagedOrderAddItemShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderAddItemShippingAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddItemShippingAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                StagedOrderAddItemShippingAddressActionQueryBuilderDsl.Of);
        }


    }
}
