using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl
    {
        public StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl>(p, StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl>(p, StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl>(p, StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl> ShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingDetails"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsDraftQueryBuilderDsl.Of())),
                StagedOrderSetCustomLineItemShippingDetailsActionQueryBuilderDsl.Of);
        }


    }
}
