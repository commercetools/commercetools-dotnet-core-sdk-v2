using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ApprovalFlowCompletedMessageQueryBuilderDsl
    {
        public ApprovalFlowCompletedMessageQueryBuilderDsl()
        {
        }

        public static ApprovalFlowCompletedMessageQueryBuilderDsl Of()
        {
            return new ApprovalFlowCompletedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalFlowCompletedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowCompletedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl>(p, ApprovalFlowCompletedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalFlowCompletedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowCompletedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl>(p, ApprovalFlowCompletedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalFlowCompletedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowCompletedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl>(p, ApprovalFlowCompletedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalFlowCompletedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowCompletedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl>(p, ApprovalFlowCompletedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ApprovalFlowCompletedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ApprovalFlowCompletedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ApprovalFlowCompletedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowCompletedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl>(p, ApprovalFlowCompletedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ApprovalFlowCompletedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ApprovalFlowCompletedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowCompletedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl>(p, ApprovalFlowCompletedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalFlowCompletedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowCompletedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl>(p, ApprovalFlowCompletedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ApprovalFlowCompletedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ApprovalFlowCompletedMessageQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowCompletedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl>(p, ApprovalFlowCompletedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl> Order(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowCompletedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("order"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl.Of())),
                ApprovalFlowCompletedMessageQueryBuilderDsl.Of);
        }


    }
}
