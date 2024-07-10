using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderRemoveItemShippingAddressActionQueryBuilderDsl
    {
        public StagedOrderRemoveItemShippingAddressActionQueryBuilderDsl()
        {
        }

        public static StagedOrderRemoveItemShippingAddressActionQueryBuilderDsl Of()
        {
            return new StagedOrderRemoveItemShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderRemoveItemShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderRemoveItemShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderRemoveItemShippingAddressActionQueryBuilderDsl>(p, StagedOrderRemoveItemShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderRemoveItemShippingAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderRemoveItemShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<StagedOrderRemoveItemShippingAddressActionQueryBuilderDsl>(p, StagedOrderRemoveItemShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
