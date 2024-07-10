using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreLanguagesChangedMessageQueryBuilderDsl
    {
        public StoreLanguagesChangedMessageQueryBuilderDsl()
        {
        }

        public static StoreLanguagesChangedMessageQueryBuilderDsl Of()
        {
            return new StoreLanguagesChangedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl>(p, StoreLanguagesChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl>(p, StoreLanguagesChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl>(p, StoreLanguagesChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl>(p, StoreLanguagesChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StoreLanguagesChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StoreLanguagesChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl>(p, StoreLanguagesChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StoreLanguagesChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl>(p, StoreLanguagesChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl>(p, StoreLanguagesChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StoreLanguagesChangedMessageQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, string> AddedLanguages()
        {
            return new ComparableCollectionPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedLanguages")),
            p => new CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl>(p, StoreLanguagesChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, string> RemovedLanguages()
        {
            return new ComparableCollectionPredicateBuilder<StoreLanguagesChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedLanguages")),
            p => new CombinationQueryPredicate<StoreLanguagesChangedMessageQueryBuilderDsl>(p, StoreLanguagesChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
