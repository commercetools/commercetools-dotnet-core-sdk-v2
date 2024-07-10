using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl
    {
        public StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl()
        {
        }

        public static StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl Of()
        {
            return new StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl>(p, StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl>(p, StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl>(p, StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl>(p, StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl>(p, StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl>(p, StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl>(p, StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl> StagedChanges(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StagedStandalonePriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StagedStandalonePriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stagedChanges"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StagedStandalonePriceQueryBuilderDsl.Of())),
                StandalonePriceStagedChangesRemovedMessageQueryBuilderDsl.Of);
        }


    }
}
