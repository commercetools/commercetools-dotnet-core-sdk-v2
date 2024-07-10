using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderCustomTypeSetMessageQueryBuilderDsl
    {
        public OrderCustomTypeSetMessageQueryBuilderDsl()
        {
        }

        public static OrderCustomTypeSetMessageQueryBuilderDsl Of()
        {
            return new OrderCustomTypeSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderCustomTypeSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderCustomTypeSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl>(p, OrderCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomTypeSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderCustomTypeSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl>(p, OrderCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomTypeSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderCustomTypeSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl>(p, OrderCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomTypeSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderCustomTypeSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl>(p, OrderCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderCustomTypeSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderCustomTypeSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderCustomTypeSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderCustomTypeSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl>(p, OrderCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                OrderCustomTypeSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderCustomTypeSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderCustomTypeSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl>(p, OrderCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomTypeSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderCustomTypeSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl>(p, OrderCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                OrderCustomTypeSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl> CustomFields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customFields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                OrderCustomTypeSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderCustomTypeSetMessageQueryBuilderDsl, string> PreviousTypeId()
        {
            return new ComparisonPredicateBuilder<OrderCustomTypeSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("previousTypeId")),
            p => new CombinationQueryPredicate<OrderCustomTypeSetMessageQueryBuilderDsl>(p, OrderCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
