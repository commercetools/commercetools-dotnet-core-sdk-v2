using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentStatusStateTransitionMessageQueryBuilderDsl
    {
        public PaymentStatusStateTransitionMessageQueryBuilderDsl()
        {
        }

        public static PaymentStatusStateTransitionMessageQueryBuilderDsl Of()
        {
            return new PaymentStatusStateTransitionMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentStatusStateTransitionMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<PaymentStatusStateTransitionMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl>(p, PaymentStatusStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentStatusStateTransitionMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<PaymentStatusStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl>(p, PaymentStatusStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentStatusStateTransitionMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<PaymentStatusStateTransitionMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl>(p, PaymentStatusStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentStatusStateTransitionMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<PaymentStatusStateTransitionMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl>(p, PaymentStatusStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                PaymentStatusStateTransitionMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                PaymentStatusStateTransitionMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentStatusStateTransitionMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<PaymentStatusStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl>(p, PaymentStatusStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                PaymentStatusStateTransitionMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentStatusStateTransitionMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<PaymentStatusStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl>(p, PaymentStatusStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentStatusStateTransitionMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentStatusStateTransitionMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl>(p, PaymentStatusStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                PaymentStatusStateTransitionMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                PaymentStatusStateTransitionMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentStatusStateTransitionMessageQueryBuilderDsl, bool> Force()
        {
            return new ComparisonPredicateBuilder<PaymentStatusStateTransitionMessageQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("force")),
            p => new CombinationQueryPredicate<PaymentStatusStateTransitionMessageQueryBuilderDsl>(p, PaymentStatusStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
