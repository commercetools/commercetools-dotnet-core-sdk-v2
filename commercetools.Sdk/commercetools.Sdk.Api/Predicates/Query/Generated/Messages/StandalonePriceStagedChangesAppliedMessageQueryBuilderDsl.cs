using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl
    {
        public StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl()
        {
        }

        public static StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl Of()
        {
            return new StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl>(p, StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl>(p, StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl>(p, StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl>(p, StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl>(p, StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl>(p, StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl>(p, StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl> StagedChanges(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StagedStandalonePriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StagedStandalonePriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stagedChanges"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StagedStandalonePriceQueryBuilderDsl.Of())),
                StandalonePriceStagedChangesAppliedMessageQueryBuilderDsl.Of);
        }


    }
}
