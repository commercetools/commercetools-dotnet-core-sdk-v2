using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductStateTransitionMessageQueryBuilderDsl
    {
        public ProductStateTransitionMessageQueryBuilderDsl()
        {
        }

        public static ProductStateTransitionMessageQueryBuilderDsl Of()
        {
            return new ProductStateTransitionMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductStateTransitionMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductStateTransitionMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl>(p, ProductStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductStateTransitionMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl>(p, ProductStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductStateTransitionMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ProductStateTransitionMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl>(p, ProductStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductStateTransitionMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ProductStateTransitionMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl>(p, ProductStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ProductStateTransitionMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ProductStateTransitionMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductStateTransitionMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ProductStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl>(p, ProductStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ProductStateTransitionMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductStateTransitionMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ProductStateTransitionMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl>(p, ProductStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductStateTransitionMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductStateTransitionMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl>(p, ProductStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ProductStateTransitionMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                ProductStateTransitionMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductStateTransitionMessageQueryBuilderDsl, bool> Force()
        {
            return new ComparisonPredicateBuilder<ProductStateTransitionMessageQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("force")),
            p => new CombinationQueryPredicate<ProductStateTransitionMessageQueryBuilderDsl>(p, ProductStateTransitionMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
