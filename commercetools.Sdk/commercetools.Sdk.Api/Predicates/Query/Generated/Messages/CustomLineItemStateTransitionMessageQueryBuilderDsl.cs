using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomLineItemStateTransitionMessageQueryBuilderDsl
    {
        public CustomLineItemStateTransitionMessageQueryBuilderDsl()
        {
        }

        public static CustomLineItemStateTransitionMessageQueryBuilderDsl Of()
        {
            return new CustomLineItemStateTransitionMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(p, CustomLineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(p, CustomLineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(p, CustomLineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(p, CustomLineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CustomLineItemStateTransitionMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CustomLineItemStateTransitionMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(p, CustomLineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                CustomLineItemStateTransitionMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(p, CustomLineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(p, CustomLineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                CustomLineItemStateTransitionMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(p, CustomLineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(p, CustomLineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, DateTime> TransitionDate()
        {
            return new ComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transitionDate")),
            p => new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(p, CustomLineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<CustomLineItemStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(p, CustomLineItemStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl> FromState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fromState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                CustomLineItemStateTransitionMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl> ToState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("toState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                CustomLineItemStateTransitionMessageQueryBuilderDsl.Of);
        }


    }
}
