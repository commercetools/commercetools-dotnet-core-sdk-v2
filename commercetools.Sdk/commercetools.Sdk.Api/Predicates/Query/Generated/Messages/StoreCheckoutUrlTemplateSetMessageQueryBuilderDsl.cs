using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl
    {
        public StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl()
        {
        }

        public static StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl Of()
        {
            return new StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl>(p, StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl>(p, StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl>(p, StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl>(p, StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl>(p, StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl>(p, StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl>(p, StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl, string> CheckoutUrlTemplate()
        {
            return new ComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("checkoutUrlTemplate")),
            p => new CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl>(p, StoreCheckoutUrlTemplateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
