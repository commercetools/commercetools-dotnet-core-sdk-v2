using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl
    {
        public StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl>(p, StagedOrderSetShippingAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
