using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ApprovalFlowCompletedMessagePayloadQueryBuilderDsl
    {
        public ApprovalFlowCompletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ApprovalFlowCompletedMessagePayloadQueryBuilderDsl Of()
        {
            return new ApprovalFlowCompletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalFlowCompletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowCompletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApprovalFlowCompletedMessagePayloadQueryBuilderDsl>(p, ApprovalFlowCompletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalFlowCompletedMessagePayloadQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowCompletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<ApprovalFlowCompletedMessagePayloadQueryBuilderDsl>(p, ApprovalFlowCompletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalFlowCompletedMessagePayloadQueryBuilderDsl> Order(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowCompletedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("order"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl.Of())),
                ApprovalFlowCompletedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
