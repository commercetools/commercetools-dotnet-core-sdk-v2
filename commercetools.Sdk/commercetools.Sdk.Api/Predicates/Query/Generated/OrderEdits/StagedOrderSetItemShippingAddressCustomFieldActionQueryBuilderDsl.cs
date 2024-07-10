using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl
    {
        public StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetItemShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
