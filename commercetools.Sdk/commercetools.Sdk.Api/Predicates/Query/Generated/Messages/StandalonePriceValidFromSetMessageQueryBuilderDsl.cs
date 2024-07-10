using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceValidFromSetMessageQueryBuilderDsl
    {
        public StandalonePriceValidFromSetMessageQueryBuilderDsl()
        {
        }

        public static StandalonePriceValidFromSetMessageQueryBuilderDsl Of()
        {
            return new StandalonePriceValidFromSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl>(p, StandalonePriceValidFromSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl>(p, StandalonePriceValidFromSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl>(p, StandalonePriceValidFromSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl>(p, StandalonePriceValidFromSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StandalonePriceValidFromSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StandalonePriceValidFromSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl>(p, StandalonePriceValidFromSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StandalonePriceValidFromSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl>(p, StandalonePriceValidFromSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl>(p, StandalonePriceValidFromSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StandalonePriceValidFromSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl>(p, StandalonePriceValidFromSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, DateTime> PreviousValidFrom()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("previousValidFrom")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromSetMessageQueryBuilderDsl>(p, StandalonePriceValidFromSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
