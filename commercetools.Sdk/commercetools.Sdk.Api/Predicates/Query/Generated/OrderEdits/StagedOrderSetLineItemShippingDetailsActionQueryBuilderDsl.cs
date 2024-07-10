using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl
    {
        public StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl>(p, StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl>(p, StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl>(p, StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl> ShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingDetails"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl.Of())),
                StagedOrderSetLineItemShippingDetailsActionQueryBuilderDsl.Of);
        }


    }
}
