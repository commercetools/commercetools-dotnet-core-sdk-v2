using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderCustomFieldRemovedMessageQueryBuilderDsl
    {
        public OrderCustomFieldRemovedMessageQueryBuilderDsl()
        {
        }

        public static OrderCustomFieldRemovedMessageQueryBuilderDsl Of()
        {
            return new OrderCustomFieldRemovedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderCustomFieldRemovedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderCustomFieldRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderCustomFieldRemovedMessageQueryBuilderDsl>(p, OrderCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomFieldRemovedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderCustomFieldRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderCustomFieldRemovedMessageQueryBuilderDsl>(p, OrderCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomFieldRemovedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderCustomFieldRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderCustomFieldRemovedMessageQueryBuilderDsl>(p, OrderCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomFieldRemovedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderCustomFieldRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderCustomFieldRemovedMessageQueryBuilderDsl>(p, OrderCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomFieldRemovedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomFieldRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderCustomFieldRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderCustomFieldRemovedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomFieldRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderCustomFieldRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderCustomFieldRemovedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderCustomFieldRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<OrderCustomFieldRemovedMessageQueryBuilderDsl>(p, OrderCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomFieldRemovedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomFieldRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                OrderCustomFieldRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderCustomFieldRemovedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderCustomFieldRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderCustomFieldRemovedMessageQueryBuilderDsl>(p, OrderCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomFieldRemovedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderCustomFieldRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderCustomFieldRemovedMessageQueryBuilderDsl>(p, OrderCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomFieldRemovedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomFieldRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                OrderCustomFieldRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderCustomFieldRemovedMessageQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<OrderCustomFieldRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<OrderCustomFieldRemovedMessageQueryBuilderDsl>(p, OrderCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
