using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ApprovalFlowRejectedMessagePayloadQueryBuilderDsl
    {
        public ApprovalFlowRejectedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ApprovalFlowRejectedMessagePayloadQueryBuilderDsl Of()
        {
            return new ApprovalFlowRejectedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalFlowRejectedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowRejectedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApprovalFlowRejectedMessagePayloadQueryBuilderDsl>(p, ApprovalFlowRejectedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalFlowRejectedMessagePayloadQueryBuilderDsl> Associate(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowRejectedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                ApprovalFlowRejectedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ApprovalFlowRejectedMessagePayloadQueryBuilderDsl, string> RejectionReason()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowRejectedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("rejectionReason")),
            p => new CombinationQueryPredicate<ApprovalFlowRejectedMessagePayloadQueryBuilderDsl>(p, ApprovalFlowRejectedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalFlowRejectedMessagePayloadQueryBuilderDsl> Order(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowRejectedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("order"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl.Of())),
                ApprovalFlowRejectedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
