using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceTierRemovedMessageQueryBuilderDsl
    {
        public StandalonePriceTierRemovedMessageQueryBuilderDsl()
        {
        }

        public static StandalonePriceTierRemovedMessageQueryBuilderDsl Of()
        {
            return new StandalonePriceTierRemovedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceTierRemovedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StandalonePriceTierRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl>(p, StandalonePriceTierRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceTierRemovedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StandalonePriceTierRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl>(p, StandalonePriceTierRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceTierRemovedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StandalonePriceTierRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl>(p, StandalonePriceTierRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceTierRemovedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StandalonePriceTierRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl>(p, StandalonePriceTierRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StandalonePriceTierRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StandalonePriceTierRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StandalonePriceTierRemovedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StandalonePriceTierRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl>(p, StandalonePriceTierRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StandalonePriceTierRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StandalonePriceTierRemovedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StandalonePriceTierRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl>(p, StandalonePriceTierRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceTierRemovedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceTierRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl>(p, StandalonePriceTierRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StandalonePriceTierRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl> RemovedTier(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceTierRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("removedTier"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceTierQueryBuilderDsl.Of())),
                StandalonePriceTierRemovedMessageQueryBuilderDsl.Of);
        }


    }
}
