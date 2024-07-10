using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceExternalDiscountSetMessageQueryBuilderDsl
    {
        public StandalonePriceExternalDiscountSetMessageQueryBuilderDsl()
        {
        }

        public static StandalonePriceExternalDiscountSetMessageQueryBuilderDsl Of()
        {
            return new StandalonePriceExternalDiscountSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl>(p, StandalonePriceExternalDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl>(p, StandalonePriceExternalDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl>(p, StandalonePriceExternalDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl>(p, StandalonePriceExternalDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StandalonePriceExternalDiscountSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StandalonePriceExternalDiscountSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl>(p, StandalonePriceExternalDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StandalonePriceExternalDiscountSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl>(p, StandalonePriceExternalDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl>(p, StandalonePriceExternalDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StandalonePriceExternalDiscountSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl> Discounted(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceExternalDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discounted"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceQueryBuilderDsl.Of())),
                StandalonePriceExternalDiscountSetMessageQueryBuilderDsl.Of);
        }


    }
}
