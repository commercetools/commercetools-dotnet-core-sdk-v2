using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StagedQuoteStateChangedMessageQueryBuilderDsl
    {
        public StagedQuoteStateChangedMessageQueryBuilderDsl()
        {
        }

        public static StagedQuoteStateChangedMessageQueryBuilderDsl Of()
        {
            return new StagedQuoteStateChangedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl>(p, StagedQuoteStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl>(p, StagedQuoteStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl>(p, StagedQuoteStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl>(p, StagedQuoteStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StagedQuoteStateChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StagedQuoteStateChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl>(p, StagedQuoteStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StagedQuoteStateChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl>(p, StagedQuoteStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl>(p, StagedQuoteStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StagedQuoteStateChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, string> StagedQuoteState()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stagedQuoteState")),
            p => new CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl>(p, StagedQuoteStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, string> OldStagedQuoteState()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldStagedQuoteState")),
            p => new CombinationQueryPredicate<StagedQuoteStateChangedMessageQueryBuilderDsl>(p, StagedQuoteStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
