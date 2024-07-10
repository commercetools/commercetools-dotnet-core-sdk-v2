using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ApprovalFlowApprovedMessagePayloadQueryBuilderDsl
    {
        public ApprovalFlowApprovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ApprovalFlowApprovedMessagePayloadQueryBuilderDsl Of()
        {
            return new ApprovalFlowApprovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalFlowApprovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowApprovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApprovalFlowApprovedMessagePayloadQueryBuilderDsl>(p, ApprovalFlowApprovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalFlowApprovedMessagePayloadQueryBuilderDsl> Associate(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowApprovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                ApprovalFlowApprovedMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ApprovalFlowApprovedMessagePayloadQueryBuilderDsl> Order(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowApprovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("order"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl.Of())),
                ApprovalFlowApprovedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
