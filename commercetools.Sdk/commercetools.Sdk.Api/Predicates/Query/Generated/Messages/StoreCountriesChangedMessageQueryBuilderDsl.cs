using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreCountriesChangedMessageQueryBuilderDsl
    {
        public StoreCountriesChangedMessageQueryBuilderDsl()
        {
        }

        public static StoreCountriesChangedMessageQueryBuilderDsl Of()
        {
            return new StoreCountriesChangedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl>(p, StoreCountriesChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl>(p, StoreCountriesChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl>(p, StoreCountriesChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl>(p, StoreCountriesChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StoreCountriesChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StoreCountriesChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl>(p, StoreCountriesChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StoreCountriesChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl>(p, StoreCountriesChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl>(p, StoreCountriesChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StoreCountriesChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl> AddedCountries(
            Func<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addedCountries"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl.Of())),
                StoreCountriesChangedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl> AddedCountries()
        {
            return new CollectionPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedCountries")),
                    p => new CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl>(p, StoreCountriesChangedMessageQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl> RemovedCountries(
            Func<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("removedCountries"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl.Of())),
                StoreCountriesChangedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl> RemovedCountries()
        {
            return new CollectionPredicateBuilder<StoreCountriesChangedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedCountries")),
                    p => new CombinationQueryPredicate<StoreCountriesChangedMessageQueryBuilderDsl>(p, StoreCountriesChangedMessageQueryBuilderDsl.Of));
        }

    }
}
