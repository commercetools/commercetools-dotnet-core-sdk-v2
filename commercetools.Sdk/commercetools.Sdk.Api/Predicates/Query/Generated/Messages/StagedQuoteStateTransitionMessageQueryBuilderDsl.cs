using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StagedQuoteStateTransitionMessageQueryBuilderDsl
    {
        public StagedQuoteStateTransitionMessageQueryBuilderDsl()
        {
        }

        public static StagedQuoteStateTransitionMessageQueryBuilderDsl Of()
        {
            return new StagedQuoteStateTransitionMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteStateTransitionMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateTransitionMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl>(p, StagedQuoteStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteStateTransitionMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl>(p, StagedQuoteStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteStateTransitionMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateTransitionMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl>(p, StagedQuoteStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteStateTransitionMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateTransitionMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl>(p, StagedQuoteStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StagedQuoteStateTransitionMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StagedQuoteStateTransitionMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedQuoteStateTransitionMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl>(p, StagedQuoteStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StagedQuoteStateTransitionMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedQuoteStateTransitionMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl>(p, StagedQuoteStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteStateTransitionMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateTransitionMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl>(p, StagedQuoteStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StagedQuoteStateTransitionMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                StagedQuoteStateTransitionMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl> OldState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                StagedQuoteStateTransitionMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedQuoteStateTransitionMessageQueryBuilderDsl, bool> Force()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateTransitionMessageQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("force")),
            p => new CombinationQueryPredicate<StagedQuoteStateTransitionMessageQueryBuilderDsl>(p, StagedQuoteStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
