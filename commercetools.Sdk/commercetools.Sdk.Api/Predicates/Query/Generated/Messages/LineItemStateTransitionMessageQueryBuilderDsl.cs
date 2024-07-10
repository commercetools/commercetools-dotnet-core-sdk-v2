using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class LineItemStateTransitionMessageQueryBuilderDsl
    {
        public LineItemStateTransitionMessageQueryBuilderDsl()
        {
        }

        public static LineItemStateTransitionMessageQueryBuilderDsl Of()
        {
            return new LineItemStateTransitionMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(p, LineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(p, LineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(p, LineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(p, LineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                LineItemStateTransitionMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                LineItemStateTransitionMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(p, LineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                LineItemStateTransitionMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(p, LineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(p, LineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                LineItemStateTransitionMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(p, LineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(p, LineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, DateTime> TransitionDate()
        {
            return new ComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transitionDate")),
            p => new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(p, LineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<LineItemStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(p, LineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl> FromState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fromState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                LineItemStateTransitionMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl> ToState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("toState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                LineItemStateTransitionMessageQueryBuilderDsl.Of);
        }


    }
}
