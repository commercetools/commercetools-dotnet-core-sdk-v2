using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderUpdateItemShippingAddressActionQueryBuilderDsl
    {
        public StagedOrderUpdateItemShippingAddressActionQueryBuilderDsl()
        {
        }

        public static StagedOrderUpdateItemShippingAddressActionQueryBuilderDsl Of()
        {
            return new StagedOrderUpdateItemShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderUpdateItemShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderUpdateItemShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderUpdateItemShippingAddressActionQueryBuilderDsl>(p, StagedOrderUpdateItemShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderUpdateItemShippingAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateItemShippingAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                StagedOrderUpdateItemShippingAddressActionQueryBuilderDsl.Of);
        }


    }
}
