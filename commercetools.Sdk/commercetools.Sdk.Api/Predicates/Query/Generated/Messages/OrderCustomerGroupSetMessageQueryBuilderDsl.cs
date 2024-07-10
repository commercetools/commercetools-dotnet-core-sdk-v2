using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderCustomerGroupSetMessageQueryBuilderDsl
    {
        public OrderCustomerGroupSetMessageQueryBuilderDsl()
        {
        }

        public static OrderCustomerGroupSetMessageQueryBuilderDsl Of()
        {
            return new OrderCustomerGroupSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderCustomerGroupSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderCustomerGroupSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl>(p, OrderCustomerGroupSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomerGroupSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderCustomerGroupSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl>(p, OrderCustomerGroupSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomerGroupSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderCustomerGroupSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl>(p, OrderCustomerGroupSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomerGroupSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderCustomerGroupSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl>(p, OrderCustomerGroupSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderCustomerGroupSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderCustomerGroupSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderCustomerGroupSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderCustomerGroupSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl>(p, OrderCustomerGroupSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                OrderCustomerGroupSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderCustomerGroupSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderCustomerGroupSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl>(p, OrderCustomerGroupSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomerGroupSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderCustomerGroupSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl>(p, OrderCustomerGroupSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                OrderCustomerGroupSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl.Of())),
                OrderCustomerGroupSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl> OldCustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomerGroupSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldCustomerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl.Of())),
                OrderCustomerGroupSetMessageQueryBuilderDsl.Of);
        }


    }
}
